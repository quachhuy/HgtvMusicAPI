using HgtvMusicAPI.Data;
using HgtvMusicAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HgtvMusicAPI.Services
{
    public class SongRepository : ISongRepository
    {
        private readonly MyDbContext _context;
        public SongRepository(MyDbContext context)
        {
            _context = context;
        }

        public SongVM CreateSong(SongModel model)
        {
            var song = new Song
            {
                NameSong = model.NameSong,
                Path_Img = model.Path_Img
            };
            _context.Add(song);
            _context.SaveChanges();
            return new SongVM
            {
                IdSong = song.IdSong,
                NameSong = song.NameSong,
                Path_Img = song.Path_Img
            };
        }

        public void Delete(int id)
        {
            var song = _context.Songs.SingleOrDefault(si => si.IdSong == id);
            if (song != null)
            {
                _context.Remove(song);
                _context.SaveChanges();
            }
        }

        public List<SongVM> GetAll()
        {
            var song = _context.Songs.Select(si => new SongVM
            {
                NameSong = si.NameSong,
                Path_Img = si.Path_Img
            });
            return song.ToList();
        }

        public SongVM GetById(int id)
        {
            var song = _context.Songs.SingleOrDefault(si => si.IdSong == id);
            if (song != null)
            {
                return new SongVM
                {
                    NameSong = song.NameSong,
                    Path_Img = song.Path_Img
                };

            }
            return null;
        }

        public void UpdateSong(SongVM SongVM)
        {
            var song = _context.Songs.SingleOrDefault(si => si.IdSong == SongVM.IdSong); // chu y
            SongVM.NameSong = SongVM.NameSong;
            SongVM.Path_Img = SongVM.Path_Img;

            _context.SaveChanges();
        }
    }
}

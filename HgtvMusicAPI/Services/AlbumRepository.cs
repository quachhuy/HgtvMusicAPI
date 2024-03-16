using HgtvMusicAPI.Data;
using HgtvMusicAPI.Models;

namespace HgtvMusicAPI.Services
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly MyDbContext _context;
        public AlbumRepository(MyDbContext context)
        {
            _context = context;
        }

        public AlbumVM CreateAlbum(AlbumModel model)
        {
            var album = new Album
            {
                NameAlbum   = model.NameAlbum,
                ReleaseYear = model.ReleaseYear,
                Quantity    = model.Quantity,
                Path_Img    = model.Path_Img
            };
            _context.Add(album);
            _context.SaveChanges();
            return new AlbumVM
            {
                IdAlbum     = album.IdAlbum,
                NameAlbum   = album.NameAlbum,
                ReleaseYear = album.ReleaseYear,
                Path_Img    = album.Path_Img
            };
        }

        public void Delete(int id)
        {
            var album = _context.Albums.SingleOrDefault(si => si.IdAlbum == id);
            if (album != null)
            {
                _context.Remove(album);
                _context.SaveChanges();
            }
        }

        public List<AlbumVM> GetAll()
        {
            var album = _context.Albums.Select(al => new AlbumVM
            {
                NameAlbum   = al.NameAlbum,
                ReleaseYear = al.ReleaseYear,
                Quantity    = al.Quantity,
                Path_Img    = al.Path_Img
            });
            return album.ToList();
        }

        public AlbumVM GetById(int id)
        {
            var album = _context.Albums.SingleOrDefault(al => al.IdAlbum == id);
            if (album != null)
            {
                return new AlbumVM
                {
                    IdAlbum = album.IdAlbum,
                    NameAlbum = album.NameAlbum,
                    ReleaseYear = album.ReleaseYear,
                    Path_Img = album.Path_Img
                };

            }
            return null;
        }

        public void UpdateAlbum(AlbumVM AlbumVM)
        {
            var album = _context.Albums.SingleOrDefault(si => si.IdAlbum == AlbumVM.IdAlbum); // chu y
            AlbumVM.NameAlbum   = AlbumVM.NameAlbum;
            AlbumVM.ReleaseYear = AlbumVM.ReleaseYear;
            AlbumVM.Quantity    = AlbumVM.Quantity;
            AlbumVM.Path_Img    = AlbumVM.Path_Img;

            _context.SaveChanges();
        }
    }
}

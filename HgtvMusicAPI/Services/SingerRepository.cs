using HgtvMusicAPI.Data;
using HgtvMusicAPI.Models;

namespace HgtvMusicAPI.Services
{
    public class SingerRepository : ISingerRepository
    {
        private readonly MyDbContext _context;
        public SingerRepository(MyDbContext context)
        {
            _context = context;
        }
        SingerVM ISingerRepository.CreateSinger(SingerModel model)
        {
            var singer = new Singer
            {
                NameSinger = model.NameSinger,
                Follower = model.Follower,
                Path_Img = model.Path_Img
            };
            _context.Add(singer);
            _context.SaveChanges();
            return new SingerVM
            {
                IdSinger = singer.IdSinger,
                NameSinger = singer.NameSinger,
                Follower = singer.Follower,
                Path_Img = singer.Path_Img
            };
        }

        void ISingerRepository.Delete(int id)
        {

            var singer = _context.Singers.SingleOrDefault(si => si.IdSinger == id);
            if (singer != null)
            {
                _context.Remove(singer);
                _context.SaveChanges();
            }
        }

        List<SingerVM> ISingerRepository.GetAll()
        {
            var singers = _context.Singers.Select(si => new SingerVM
            {
                NameSinger = si.NameSinger,
                Follower = si.Follower,
                Path_Img = si.Path_Img
            });
            return singers.ToList();
        }

        SingerVM ISingerRepository.GetById(int id)
        {
            var singer = _context.Singers.SingleOrDefault(si => si.IdSinger == id);
            if(singer != null)
            {
                return new SingerVM
                {
                    NameSinger = singer.NameSinger,
                    Follower = singer.Follower,
                    Path_Img = singer.Path_Img
                };

            }
            return null;
        }

        void ISingerRepository.UpdateSingerById(SingerVM singerVM)
        {
            var singer = _context.Singers.SingleOrDefault(si => si.IdSinger == singerVM.IdSinger); // chu y
            singerVM.NameSinger = singerVM.NameSinger;
            singerVM.Follower = singerVM.Follower;
            singerVM.Path_Img = singerVM.Path_Img;

                _context.SaveChanges();

        }
    }
}

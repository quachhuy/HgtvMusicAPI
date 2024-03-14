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
            throw new NotImplementedException();
        }

        void ISingerRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<SingerVM> ISingerRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        SingerVM ISingerRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void ISingerRepository.Update(SingerVM singerVM)
        {
            throw new NotImplementedException();
        }
    }
}

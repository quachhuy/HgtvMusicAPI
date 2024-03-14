using HgtvMusicAPI.Models;

namespace HgtvMusicAPI.Services
{
    public interface ISingerRepository
    {
        List<SingerVM> GetAll();
        SingerVM GetById(int id);

        SingerVM CreateSinger(SingerModel model);

        void Update(SingerVM singerVM);
        void Delete(int id);   

    }
}

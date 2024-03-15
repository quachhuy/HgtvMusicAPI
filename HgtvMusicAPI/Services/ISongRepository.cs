using HgtvMusicAPI.Models;

namespace HgtvMusicAPI.Services
{
    public interface ISongRepository
    {
        List<SongVM> GetAll();
        SongVM GetById(int id);

        SongVM CreateSong(SongModel model);

        void UpdateSong(SongVM SongVM);
        void Delete(int id);
    }
}

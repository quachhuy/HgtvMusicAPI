using HgtvMusicAPI.Models;

namespace HgtvMusicAPI.Services
{
    public interface IAlbumRepository
    {
        List<AlbumVM> GetAll();
        AlbumVM GetById(int id);

        AlbumVM CreateAlbum(AlbumModel model);

        void UpdateAlbum(AlbumVM albumVM);
        void Delete(int id);
    }
}

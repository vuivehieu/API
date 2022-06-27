using Project3_jamesthew.Entitites;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Repository
{
    public interface ITipsRepository
    {
        Task<IEnumerable<TipsEntity>> GetAllTips();
        Task<TipsEntity> GetTipsById(int Id);
        Task<TipsEntity> AddTips(TipsEntity tips);
        Task<TipsEntity> UpdateTips(TipsEntity tips);
        Task DeleteTips(int Id);
        bool CateModelExists(int id);
        Task<string> SaveImage(IFormFile imageFile);
        void DeleteImage(string imageName);
    }
}

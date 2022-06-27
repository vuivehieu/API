using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public interface IAnnounceRepository
    {
        Task<List<AnnounceEntity>> GetAllAnnounce();
        Task<AnnounceEntity> GetCAnnounceById(int Id);
        Task<AnnounceEntity> AddAnnounce(AnnounceEntity announce);
        Task<AnnounceEntity> UpdateAnnounce(AnnounceEntity announce);
        Task DeleteAnnounce(int Id);
    }
}

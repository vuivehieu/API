using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public interface IContestRepository
    {
        Task<List<ContestEntity>> GetAllContest();
        Task<ContestEntity> GetContestById(int Id);
        Task<ContestEntity> AddContest(ContestEntity contest);
        Task<ContestEntity> UpdateContest(ContestEntity contest);
        Task DeleteContest(int Id);
    }
}

using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public class ContestRepository : IContestRepository
    {
        private readonly DataContext _context;
        public ContestRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<ContestEntity>> GetAllContest()
        {
            return await _context.contests.ToListAsync();
        }

        public async Task<ContestEntity> GetContestById(int Id)
        {
            return await _context.contests.FirstOrDefaultAsync(c => c.ContestId == Id);
        }

        public async Task<ContestEntity> AddContest(ContestEntity contest)
        {
            var result = await _context.AddAsync(contest);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteContest(int Id)
        {
            var result = await _context.contests.SingleOrDefaultAsync(c => c.ContestId == Id);
            if(result != null)
            {
                 _context.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ContestEntity> UpdateContest(ContestEntity contest)
        {
            var result = await _context.contests
                .FirstOrDefaultAsync(c => c.ContestId == contest.ContestId);
            if( result != null)
            {
                result.ContestId = contest.ContestId;
                result.ContestTitle = contest.ContestTitle;
                result.ContestStart = contest.ContestStart;
                result.ContestEnd = contest.ContestEnd;
                result.CategoryId = contest.CategoryId;
                result.IsOpen = contest.IsOpen;
                result.ContestDescription = contest.ContestDescription;
                await _context.SaveChangesAsync();
            }
            return null;
        }
    }
}

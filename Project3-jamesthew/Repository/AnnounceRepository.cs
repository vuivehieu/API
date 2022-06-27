using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Data;
using Project3_jamesthew.Entitites;

namespace Project3_jamesthew.Repository
{
    public class AnnounceRepository : IAnnounceRepository
    {
        private readonly DataContext _context;
        public AnnounceRepository(DataContext context)
        {
            this._context = context;
        }
        public async Task<List<AnnounceEntity>> GetAllAnnounce()
        {
            return await _context.announces.ToListAsync();
        }

        public async Task<AnnounceEntity> GetCAnnounceById(int Id)
        {
            return await _context.announces.FirstOrDefaultAsync(a=> a.AnnounceId ==Id);
        }

        public  async Task<AnnounceEntity> AddAnnounce(AnnounceEntity announce)
        {
            var AddAnnounce = await _context.AddAsync(announce);
            await _context.SaveChangesAsync();
            return AddAnnounce.Entity;
        }

        public async Task DeleteAnnounce(int Id)
        {
            var getId = await _context.announces.SingleOrDefaultAsync(a => a.AnnounceId == Id);
            if(getId != null)
            {
                 _context.Remove(getId);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task<AnnounceEntity> UpdateAnnounce(AnnounceEntity announce)
        {
            var result = await _context.announces
                .FirstOrDefaultAsync(a => a.AnnounceId == announce.AnnounceId);
            if(result != null)
            {
                result.AnnounceId = announce.AnnounceId;
                result.AnnounceDate = announce.AnnounceDate;
                result.Email = announce.Email;
                result.ContestId = announce.ContestId;
                result.RecipeCompetitionId = announce.RecipeCompetitionId;
                await _context.SaveChangesAsync();
            }
            return null;
        }
    }
}

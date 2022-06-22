using Microsoft.EntityFrameworkCore;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Data;

namespace Project3_jamesthew.Repository
{
    public class TipsRepository : ITipsRepository
    {
        private readonly DataContext _context;
        public TipsRepository(DataContext context)
        {
           this._context = context;
        }

        public async Task<IEnumerable<TipsEntity>> GetAllTips()
        {
            return await _context.tipsEntities.ToListAsync();
        }

        public async Task<TipsEntity> GetTipsById(int Id)
        {
            return await _context.tipsEntities.FirstOrDefaultAsync(t => t.TipsId == Id);
        }

        public async Task<TipsEntity> AddTips(TipsEntity tips)
        {
            var result = await _context.tipsEntities.AddAsync(tips);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<TipsEntity> UpdateTips(TipsEntity tips)
        {
            var result = await _context.tipsEntities
                .FirstOrDefaultAsync(t => t.TipsId == tips.TipsId);
            if(result != null)
            {
                result.TipsTitle = tips.TipsTitle;
                result.TipsDescription = tips.TipsDescription;
                result.TipsImage = tips.TipsImage;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task DeleteTips(int Id)
        {
            var result = await _context.tipsEntities.SingleOrDefaultAsync(t=>t.TipsId ==Id);
            if(result != null)
            {
                _context.tipsEntities.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

    }
}

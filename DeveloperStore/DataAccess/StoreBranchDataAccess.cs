using DeveloperStore.BusinessEntity;
using DeveloperStoreAPI.Data;

namespace DeveloperStore.DataAccess
{
    public class StoreBranchDataAccess
    {
        private readonly AppDbContext _context;
        public StoreBranchDataAccess (AppDbContext context)
        {
            _context = context;
        }
        public List<StoreBranch> GetAllStoreBranches()
        {
            return _context.StoreBranches.ToList();
        }
        public StoreBranch GetStoreBranchById(Guid id)
        {
            return _context.StoreBranches.FirstOrDefault(c => c.Id == id);
        }
        public void CreateStoreBranch(StoreBranch storeBranch)
        {
            _context.StoreBranches.Add(storeBranch);
            _context.SaveChanges();
        }
        public bool UpdateStoreBranch(Guid id, StoreBranch updatedBranch)
        {
            StoreBranch storeBranch = _context.StoreBranches.FirstOrDefault(c => c.Id == id);
            if (storeBranch == null) return false;

            storeBranch.Name = updatedBranch.Name;
            storeBranch.Address = updatedBranch.Address;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteStoreBranch(Guid id)
        {
            StoreBranch storeBranch = _context.StoreBranches.FirstOrDefault(c => c.Id == id);
            if (storeBranch == null) return false;
            _context.StoreBranches.Remove(storeBranch);
            _context.SaveChanges();
            return true;
        }
    }
}

using DeveloperStore.BusinessEntity;
using DeveloperStore.DataAccess;

namespace DeveloperStore.Business
{
    public class StoreBranchBO
    {
        private readonly StoreBranchDataAccess _storeBranchDataAccess;

        public StoreBranchBO(StoreBranchDataAccess storeBranchDataAccess)
        {
            _storeBranchDataAccess = storeBranchDataAccess;
        }

        public List<StoreBranch> GetAllStoreBranches()
        {
            return _storeBranchDataAccess.GetAllStoreBranches();
        }

        public StoreBranch GetStoreBranchById(Guid id)
        {
            return _storeBranchDataAccess.GetStoreBranchById(id);
        }

        public StoreBranch CreateStoreBranch(StoreBranch storeBranch)
        {
            _storeBranchDataAccess.CreateStoreBranch(storeBranch);
            return storeBranch;
        }

        public bool UpdateStoreBranch(Guid id, StoreBranch updatedStoreBranch)
        {
            return _storeBranchDataAccess.UpdateStoreBranch(id, updatedStoreBranch);
        }

        public bool DeleteStoreBranch(Guid id)
        {
            return _storeBranchDataAccess.DeleteStoreBranch(id);
        }
    }
}

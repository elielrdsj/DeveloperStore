using DeveloperStore.BusinessEntity;
using DeveloperStore.DataAccess;
using DeveloperStoreAPI.Models;

namespace DeveloperStore.Business
{
    public class SalesBO
    {
        private readonly SalesDataAccess _salesDataAccess;

        public SalesBO(SalesDataAccess salesDataAccess)
        {
            _salesDataAccess = salesDataAccess;
        }

        public List<Sale> GetAllSales()
        {
            return _salesDataAccess.GetAllSales();
        }

        public Sale GetSaleById(Guid id)
        {
            return _salesDataAccess.GetSaleById(id);
        }

        public Sale CreateSale(Sale sale)
        {
            _salesDataAccess.CreateSale(sale);
            return sale;
        }

        public bool UpdateSale(Guid id, Sale updatedSale)
        {
            return _salesDataAccess.UpdateSale(id, updatedSale);
        }

        public bool DeleteSale(Guid id)
        {
            return _salesDataAccess.DeleteSale(id);
        }
    }
}

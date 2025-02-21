using DeveloperStoreAPI.Data;
using DeveloperStoreAPI.Models;

namespace DeveloperStore.DataAccess
{
    public class SalesDataAccess
    {
        private readonly AppDbContext _context;

        public SalesDataAccess(AppDbContext context)
        {
            _context = context;
        }

        public List<Sale> GetAllSales()
        {
            return _context.Sales.ToList();
        }

        public Sale GetSaleById(Guid id)
        {
            return _context.Sales.FirstOrDefault(s => s.Id == id);
        }

        public void CreateSale(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
        }

        public bool UpdateSale(Guid id, Sale updatedSale)
        {
            var sale = _context.Sales.FirstOrDefault(s => s.Id == id);
            if (sale == null) return false;

            sale.SaleNumber = updatedSale.SaleNumber;
            sale.SaleDate = updatedSale.SaleDate;
            sale.CustomerId = updatedSale.CustomerId;
            sale.BranchId = updatedSale.BranchId;
            sale.Items = updatedSale.Items;
            sale.IsCancelled = updatedSale.IsCancelled;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteSale(Guid id)
        {
            var sale = _context.Sales.FirstOrDefault(s => s.Id == id);
            if (sale == null) return false;

            _context.Sales.Remove(sale);
            _context.SaveChanges();
            return true;
        }
    }
}

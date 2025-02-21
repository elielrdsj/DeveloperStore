using DeveloperStore.BusinessEntity;
using DeveloperStoreAPI.Models;

namespace DeveloperStore.Business
{
    public class SaleBusiness
    {
        public static decimal CalculateTotalAmount(Sale sale)
        {
            return sale.Items.Sum(item => CalculateTotalPrice(item));
        }

        public static decimal CalculateTotalPrice(SaleItem item)
        {
            return (item.UnitPrice * item.Quantity) - CalculateDiscount(item);
        }

        public static decimal CalculateDiscount(SaleItem item)
        {
            if (item.Quantity < 4) return 0;
            if (item.Quantity >= 4 && item.Quantity < 10) return (item.UnitPrice * item.Quantity) * 0.10m;
            if (item.Quantity >= 10 && item.Quantity <= 20) return (item.UnitPrice * item.Quantity) * 0.20m;
            return 0;
        }
    }
}

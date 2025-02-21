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
        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
        public Customer GetCustomerById(Guid id)
        {
            return _context.Customers.FirstOrDefault(c => c.Id == id);
        }
        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public bool UpdateCustomer(Guid id, Customer updatedCustomer)
        {
            Customer customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer == null) return false;

            customer.Name = updatedCustomer.Name;
            customer.Email = updatedCustomer.Email;
            customer.PhoneNumber = updatedCustomer.PhoneNumber;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteCustomer(Guid id)
        {
            Customer customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer == null) return false;
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return true;
        }
    }
}

using DeveloperStore.BusinessEntity;
using DeveloperStore.DataAccess;

namespace DeveloperStore.Business
{
    public class CustomerBO
    {
        private readonly CustomerDataAccess _customerDataAccess;

        public CustomerBO(CustomerDataAccess customerDataAccess)
        {
            _customerDataAccess = customerDataAccess;
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerDataAccess.GetAllCustomers();
        }

        public Customer GetCustomerById(Guid id)
        {
            return _customerDataAccess.GetCustomerById(id);
        }

        public Customer CreateCustomer(Customer customer)
        {
            _customerDataAccess.CreateCustomer(customer);
            return customer;
        }

        public bool UpdateCustomer(Guid id, Customer updatedCustomer)
        {
            return _customerDataAccess.UpdateCustomer(id, updatedCustomer);
        }

        public bool DeleteCustomer(Guid id)
        {
            return _customerDataAccess.DeleteCustomer(id);
        }
    }
}
}

using System.Collections.Generic;
using Ejoint.CustomerDatabase.Model;

namespace Ejoint.CustomerDatabase.Operations
{
    interface ICustomerDatabaseContract
    {
        int SaveCustomer(Customer customer);
        int UpdateCustomer(int customerID, Customer customer);
        int DeleteCustomer(int customerID);
        List<Customer> GetCustomerDetails();
        Customer GetCustomer(int customerID);
    }
}

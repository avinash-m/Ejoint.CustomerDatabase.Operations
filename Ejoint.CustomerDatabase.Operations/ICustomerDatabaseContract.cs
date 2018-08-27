using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

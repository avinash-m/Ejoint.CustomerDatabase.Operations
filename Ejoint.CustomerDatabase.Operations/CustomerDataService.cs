using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Ejoint.CustomerDatabase.Operations
{
    class CustomerDataService : ICustomerDatabaseContract
    {
        private SqlConnection conn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader sdr;

        public CustomerDataService(string connectionString)
        {
            conn.ConnectionString = connectionString;
            cmd.Connection = conn;
        }

        public Customer GetCustomer(int customerID)
        {
            Customer customer = new Customer();

            try
            {
                conn.Open();
                cmd.CommandText = "usp_Get";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", customer.ID);
                sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        customer.ID = (int)sdr["ID"];
                        customer.FirstName = sdr["FirstName"].ToString();
                        customer.LastName = sdr["LastName"].ToString();
                        customer.DOB = (DateTime)sdr["DOB"];
                        customer.Gender = (char)sdr["Gender"];
                        customer.CreatedDate = (DateTime)sdr["CreatedDate"];
                        customer.UpdatedDate = (DateTime)sdr["UpdatedDate"];
                        customer.IsActive = (bool)sdr["IsActive"];
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return customer;
        }

        public List<Customer> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }

        public int SaveCustomer(Customer customer)
        {
            int rowsEffected = 0;
            try
            {
                conn.Open();
                cmd.CommandText = "usp_Insert";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", customer.ID);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@DOB", customer.DOB);
                cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                cmd.Parameters.AddWithValue("@CreatedDate", customer.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", customer.UpdatedDate);
                cmd.Parameters.AddWithValue("@IsActive", customer.IsActive);
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return rowsEffected;
        }

        public int UpdateCustomer(int customerID, Customer customer)
        {
            int rowsEffected = 0;
            try
            {
                conn.Open();
                cmd.CommandText = "usp_Update";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", customer.ID);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@DOB", customer.DOB);
                cmd.Parameters.AddWithValue("@Gender", customer.Gender);
                cmd.Parameters.AddWithValue("@CreatedDate", customer.CreatedDate);
                cmd.Parameters.AddWithValue("@UpdatedDate", customer.UpdatedDate);
                cmd.Parameters.AddWithValue("@IsActive", customer.IsActive);
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return rowsEffected;
        }

        public int DeleteCustomer(int customerID)
        {
            int rowsEffected = 0;
            try
            {
                conn.Open();
                cmd.CommandText = "usp_Delete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", customerID);
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return rowsEffected;
        }

    }
}

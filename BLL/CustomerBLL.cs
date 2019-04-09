using WebMVC.Models;
using System.Collections.Generic;
using DAL;
using System;
namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL customer_dal = new CustomerDAL();
        public IEnumerable<CUSTOMER> GetAll()
        {
            return customer_dal.GetAll();
        }
        public string Create(string name, int identity, string job, string position, string address, string email)
        {
            customer_dal.setCustomer(name, identity, job, position, address,email);
            if (name == "" || identity.ToString() == "" || job == "" || position == "" || address == "" || email == "")
            {
                return "Vui lòng nhập thông tin khách hàng";
            }
            else if (!checkExistCustomer())
            {
                customer_dal.Create();
                return "Thêm khách hàng thành công !";
            }
            else
                return "Thông tin khách hàng bị trùng";
        }

        public string Delete(string id)
        {
            customer_dal.setCustomer(id);
            customer_dal.Delete();
            return "Xóa thông tin khách hàng thành công !";
        }

        public string Update(string id, string name, int identity, string job, string position, string address, string email)
        {
            customer_dal.setCustomer(id, name, identity, job, position, address, email);
            if (name == "" || identity.ToString() == "" || job == "" || position == "" || address == "" || email =="")
            {
                return "Vui lòng nhập thông tin khách hàng";
            }
            else if (!checkExistCustomer())
            {
                customer_dal.Update();
                return "Sửa thông tin khách hàng thành công !";
            }
            else
                return "Thông tin khách hàng bị trùng !";
        }
        public IEnumerable<CUSTOMER> SearchByName(string name)
        {
            return customer_dal.SearchByName(name);
        }
        public List<CUSTOMER> SearchById_Customer(string id_customer)
        {
            return customer_dal.SearchById_Customer(id_customer);
        }

        public bool checkExistCustomer()
        {
            return customer_dal.checkExistCustomer();
        }
        public string getName_in_Customer(string id_customer)
        {
            return customer_dal.getName_in_Customer(id_customer);
        }
        public string getEmail_in_Customer(string id_customer)
        {
            return customer_dal.getEmail_in_Customer(id_customer);
        }

        public string getAddress_in_Customer(string id_customer)
        {
            return customer_dal.getAddress_in_Customer(id_customer);
        }
    }
}
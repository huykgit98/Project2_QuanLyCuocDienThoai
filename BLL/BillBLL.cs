using WebMVC.Models;
using System.Collections.Generic;
using DAL;
using System;


namespace BLL
{
    public class BillBLL
    {
        BillDAL bill_dal = new BillDAL();
        public IEnumerable<BILL> GetAll()
        {
            return bill_dal.GetAll();
        }
        public string Create(string id_sim, DateTime date_ex, DateTime invoice_date, DateTime date_cut, int postage, int fare, bool status)
        {
            if (checkIfExist())
            { return "Hóa đơn này đã lập trong tháng " + date_ex.Month + " năm " + date_ex.Year; }
            else
            {
                bill_dal.setBill(id_sim, date_ex, invoice_date, date_cut, postage, fare, status);
                bill_dal.Create();
                return "Thêm thành công hóa đơn và hóa đơn gửi đến mail khách hàng";
            }
        }

        public bool checkIfExist()
        {
            return bill_dal.checkIfExist();
        }
        public void Delete(string id)
        {
            bill_dal.setBill(id);
            bill_dal.Delete();
        }

        public void Update(string id, string id_sim, DateTime date_ex,DateTime invoice_date, DateTime date_cut, int postage, int fare, bool status)
        {
            bill_dal.setBill(id, id_sim, date_ex, invoice_date, date_cut, postage, fare, status);
            bill_dal.Update();
        }
        public void Pay(string id)
        {
            bill_dal.setBill(id);
            bill_dal.Pay();
        }
        public IEnumerable<BILL> SearchBy_CustomerName(string name)
        {
            return bill_dal.SearchBy_CustomerName(name);
        }

        public bool SendBillByEmail(string toMail, string name_customer, string id_sim, DateTime date_ex, DateTime invoice_date, DateTime date_cut, int postage, int fare)
        {
            bill_dal.setBill(id_sim, date_ex, invoice_date, date_cut, postage, fare, false);
            return bill_dal.SendBillByEmail(toMail, name_customer);
        }
        public bool SendBillByEmail1(string toMail, string name_customer, string id_sim, DateTime date_ex, DateTime invoice_date, DateTime date_cut, int postage, int fare)
        {
            bill_dal.setBill(id_sim, date_ex, invoice_date, date_cut, postage, fare, false);
            return bill_dal.SendBillByEmail1(toMail, name_customer);
        }
    }
}

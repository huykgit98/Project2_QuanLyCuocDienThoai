using WebMVC.Models;
using System.Collections.Generic;
using DAL;
using System;

namespace BLL
{
    public class ContractBLL
    {
        ContractDAL contract_dal = new ContractDAL();
        public IEnumerable<CONTRACT> GetAll()
        {
            return contract_dal.GetAll();
        }
        public string Create(string sim_id, DateTime date, int? fee, bool status)
        {
            if (date > DateTime.Now)
                return "Ngày đăng ký không hợp lệ !";
            else
            {
                contract_dal.setCONTRACT(sim_id, date, fee, status);
                contract_dal.Create();
                return "Thêm thành công !";
            }
        }

        public string Delete(string id)
        {
            contract_dal.setCONTRACT(id);
            contract_dal.Delete();
            return "Xóa thành công !";
        }
        public string cancelContract_bySimID(string sim_id)
        {
            contract_dal.setCONTRACT_bySimID(sim_id);
            contract_dal.cancelContract_bySimID();
            return "Hủy thành công !";
        }
        public string Update(string id, string sim_id, DateTime date, int? fee, bool status)
        {
            if (date > DateTime.Now)
                return "Ngày đăng ký không hợp lệ !";
            else
            {
                contract_dal.setCONTRACT(id, sim_id, date, fee, status);
                contract_dal.Update();
                return "Đã lưu thay đổi !";
            }
        }
        public IEnumerable<CONTRACT> SearchBy_CustomerName(string name)
        {
            return contract_dal.SearchBy_CustomerName(name);
        }
        public bool SendContractByEmail(string toMail, string name_customer, string sim_id, DateTime date, int? fee)
        {
            contract_dal.setCONTRACT(sim_id, date, fee, false);
            return contract_dal.SendContractByEmail(toMail, name_customer);
        }
    }
}

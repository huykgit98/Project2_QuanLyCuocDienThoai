﻿using DAL;
using WebMVC.Models;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class SimBLL
    {
        SimDAL sim_dal = new SimDAL();
        public IEnumerable<SIM> GetAll()
        {
            
            return sim_dal.GetAll();
        }
        public string[] GetAll_Array()
        {
            return sim_dal.GetAll_Array();
        }
        public string Create(string id_cus, string phonenumber, bool status)
        {
            sim_dal.SetSim(id_cus, phonenumber, status);
            if (checkPhoneNumber())
                return "Số điện thoại bị trùng";
            else if (phonenumber.Length != 9)
            {
                sim_dal.Create();
                return "Thêm sim thành công !";
            }
            else
                return "Không thể thêm, Số điện thoại không hợp lệ";
        }
        public string Create1( string phonenumber, bool status)
        {
            sim_dal.setSim(phonenumber, status);
            if (checkPhoneNumber())
                return "Số điện thoại bị trùng";
            else if ((phonenumber.Length != 9) && (phonenumber.Substring(0, 1)=="0"))
            {
                sim_dal.Create();
                return "Thêm sim thành công !";
            }
            else
                return "Không thể thêm, Số điện thoại không hợp lệ (vd: 0312123423)!";
        }

        public string Delete(string id)
        {
            sim_dal.setSim(id);
            sim_dal.Delete();
            return "Xóa thành công !";
        }
        public bool checkPhoneNumber()
        {
            return sim_dal.checkPhoneNumber();
        }
        //update sim k có makh
        public string Update(string id, string phonenumber, bool status)
        {
            sim_dal.setSim1(id, phonenumber, status);
            if (checkPhoneNumber())
                return "Số điện thoại bị trùng";
            else if (phonenumber.ToString().Length != 9)
            {
                sim_dal.Update();
                return "Đã thay đổi thành công !";
            }
            else
                return "Không thể sửa, Số điện thoại không hợp lệ";

        }
        //update sim  có makh
        public string Update(string id, string id_cus, string phonenumber, bool status)
        {
            sim_dal.setSim(id, id_cus, phonenumber, status);
            if (checkPhoneNumber())
                return "Số điện thoại bị trùng";
            else if (phonenumber.ToString().Length != 9)
            {
                sim_dal.Update();
                return "Đã thay đổi thành công !";
            }
            else
                return "Không thể sửa, Số điện thoại không hợp lệ";

        }

        public void Update_ID_Customer(string id_sim, string id_customer, bool status)
        {
            sim_dal.setSim(id_sim, id_customer, status);
            sim_dal.Update_id_cus();
        }

        public string getPhone_in_Customer(string id_customer)
        {
            return sim_dal.getPhone_in_Customer(id_customer);

        }

        public List<SIM> SearchById_Sim(string id_sim)
        {
            return sim_dal.SearchByid(id_sim);
        }
        public List<SIM> SearchBy_CustomerName(string name)
        {
            return sim_dal.SearchBy_CustomerName(name);
        }

        public string getIDcustomer_in_Sim(string id_sim)
        {
            sim_dal.setSim(id_sim);
            return sim_dal.getIDcustomer_in_Sim();
        }

        public string lockSim(string id)
        {
            sim_dal.setSim(id);
            sim_dal.lockSim();
            return "Khóa SIM thành cống !";
        }
        public bool checkifLocked(string id)
        {
            sim_dal.setSim(id);
            return sim_dal.checkifLocked();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net.Mail;
using WebMVC.Models;

namespace DAL
{
    public class ContractDAL
    {
        QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();
        CONTRACT contract = new CONTRACT();
        public void setCONTRACT(String sim_id, DateTime date, int? fee, bool status)
        {
            this.contract.id_sim = sim_id;
            this.contract.fee = fee;
            this.contract.date_register = date;
            this.contract.status = status;
        }
        public void setCONTRACT(string id)
        {
            this.contract.id = id;
        }

        public void setCONTRACT_bySimID(string sim_id)
        {
            this.contract.id = sim_id;
        }

        public void setCONTRACT(string id, string sim_id, DateTime date, int? fee, bool status)
        {
            this.contract.id = id;
            this.contract.id_sim = sim_id;
            this.contract.fee = fee;
            this.contract.date_register = date;
            this.contract.status = status;
        }
        public IEnumerable<CONTRACT> GetAll()
        {
            List<CONTRACT> contract = db.CONTRACTs.ToList();
            return contract;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "C0";

            while (db.CONTRACTs.Any(c => c.id == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "C";
            }
            contract.id = id_str + numeric_value.ToString();
            db.CONTRACTs.Add(contract);
            db.SaveChanges();
            db.Entry(contract).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_contract = db.CONTRACTs.First(p => p.id == contract.id);
            var sim_id = delete_contract.id_sim;
            var customer_id = delete_contract.SIM.id_cus;
            var contract_count = db.CONTRACTs.Count(p => p.SIM.id_cus == customer_id);
            if (contract_count < 2)
            {
                IList<SIM> delete_sims = db.SIMs.Where(p => p.id_cus == customer_id).ToList();
                IList<CUSTOMER> delete_customers = db.CUSTOMERs.Where(p => p.id == customer_id).ToList();
                IList<BILL> delete_bills = db.BILLs.Where(p => p.id_sim == sim_id).ToList();
                IList<DETAIL> delete_details = db.DETAILs.Where(p => p.id_sim == sim_id).ToList();
                db.DETAILs.RemoveRange(delete_details);
                db.BILLs.RemoveRange(delete_bills);
                db.SIMs.RemoveRange(delete_sims);
                db.CUSTOMERs.RemoveRange(delete_customers);
            }

            db.CONTRACTs.Remove(delete_contract);
            db.SaveChanges();
            db.Entry(contract).State = EntityState.Detached;
        }

        public void Update()
        {
            var edited_contract = db.CONTRACTs.First(p => p.id == contract.id);
            edited_contract.id_sim = contract.id_sim;
            edited_contract.fee = contract.fee;
            edited_contract.date_register = contract.date_register;
            edited_contract.status = contract.status;
            db.SaveChanges();
            db.Entry(contract).State = EntityState.Detached;
        }
        public List<CONTRACT> SearchBy_CustomerName(string name)
        {
            if (db.CONTRACTs.Any(c => c.SIM.CUSTOMER.name_cus.Contains(name)))
            {
                List<CONTRACT> result = db.CONTRACTs.Where(c => c.SIM.CUSTOMER.name_cus.Contains(name)).ToList();
                return result;
            }
            return null;
        }
        public void cancelContract_bySimID()
        {
            var cancel_contract = db.CONTRACTs.First(p => p.id_sim == contract.id);

            cancel_contract.status = false;
            db.SaveChanges();

            db.Entry(cancel_contract).State = EntityState.Detached;
        }
        // Gửi thư thông báo hóa đơn khi đăng kí sim thành công
        public bool SendContractByEmail(string toMail, string name_customer)
        {
            MailMessage mail = new MailMessage("huykgit1998@gmail.com", toMail);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("huykgit1998@gmail.com", "Huy3612380");
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            mail.Subject = "Thông báo đăng kí sử dụng dịch vụ viễn thông";
            mail.IsBodyHtml = true;

            string htmlBody = @"
            <div style='float:left;'>
		        <div style='float:left; width:100%; padding: 2% 2%; border:1px solid #4286f4; color:white; font-size: 30px; border-top-left-radius: 10px; border-top-right-radius:10px'>
			        Thanh toán cước điện thoại hàng tháng
		        </div>
		        <div style='float:left; width:100%; background-color:#ffffff; padding: 2% 2%; border:1px solid#4286f4;'>
			        <div style='float:left; width:100%; color:#cc0000; font-size:14px;'>Đây là email tự động từ hệ thống, vui lòng không phản hồi (reply) lại email này</div>
			        <div style='float:left; width:100%;'>
				        <p>
					        <strong>Kính gửi đồng chí: " + name_customer + @"</strong>
					        <br /> 
				        </p>
			        </div>
			        <div style='float:left; width:100%; padding: 2% 2%;'>
				        <table style='border:3px solid #cc0000; width: 90%;'>
                            <tr>
						        <td>Ngày Đăng Ký:</td>
						        <td><span style='font-weight: bold;'>" + contract.date_register.ToString() + @"</span></td>
					        </tr>
					        <tr>
						        <td>Số điện thoại đăng ký:</td>
						        <td><span style='font-weight: bold;'><span style='font-weight: bold;'>" + contract.SIM.phone.ToString() + @"</span></td>
					        </tr>					        
					        <tr>
						        <td>Phí đăng kí:</td>
						        <td><span style='font-weight: bold;'>" + contract.fee.ToString() + @" VNĐ</span></td>
					        </tr>
					        <tr>
						        <td>Tổng tiền:</td>
						        <td><span style='font-weight: bold;'>" + contract.fee.ToString() + @"</span></td>
					        </tr>
				        </table>			
			        </div>
			        <div style='float:left; width:100%; padding: 2% 0%;' background-color:#ffffff; font-weight: bold;'>
				        Nếu quý khách có thắc mắc vấn đề gì có thể liên hệ qua <span style='color: #cc0000'> 0387134747 (huy nguyen) </span>. hoặc có thể đi tới địa chỉ của dịch vụ chúng tôi.
			        </div>
			        <div style='float:left; width:100%; padding: 2% 0%;' background-color:#ffffff;'>
				        Thân trọng kính chào ! <br />
				        <strong>Dịch vụ cước điện thoại Nhóm 04</strong>
			        </div>                    
		        </div>	
                <div style='float:left; width:100%; padding: 0% 2%; border:1px solid #4286f4; background-color:#4286f4;'>
			        <div style='float:left; width:3%;'>
			        </div>
			        <div style='float:left; width:50%; padding-top: 0.2%; color: white'>Nhóm 04 MHPL</div>
		        </div>	
	        </div>";

            mail.Body = htmlBody;
            client.Send(mail);
            return true;
        }
    }
}

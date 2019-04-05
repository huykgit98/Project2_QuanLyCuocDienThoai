using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net.Mail;
using WebMVC.Models;
namespace DAL
{
    public class BillDAL
    {
        QuanLyCuocDienThoai_dbEntities1 db = new QuanLyCuocDienThoai_dbEntities1();
        BILL bill = new BILL();
        public void setBill(string id, string id_sim, DateTime date_ex, DateTime invoid_date, DateTime date_cut, int postage, int fare, bool status)
        {
            this.bill.id = id;
            this.bill.id_sim = id_sim;
            this.bill.date_export = date_ex;
            this.bill.invoice_date = invoid_date;
            this.bill.date_cut = date_cut;
            this.bill.postage = postage;
            this.bill.fare = fare;
            this.bill.status = status;
        }
        public void setBill(string id_sim, DateTime date_ex, DateTime invoid_date, DateTime date_cut, int postage, int fare, bool status)
        {
            this.bill.id_sim = id_sim;
            this.bill.date_export = date_ex;
            this.bill.invoice_date = invoid_date;
            this.bill.date_cut = date_cut;
            this.bill.postage = postage;
            this.bill.fare = fare;
            this.bill.status = status;
        }
        public void setBill(string id)
        {
            this.bill.id = id;
        }
        public IEnumerable<BILL> GetAll()
        {
            List<BILL> bill = db.BILLs.ToList();
            return bill;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "B0";

            while (db.BILLs.Any(c => c.id == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "B";
            }
            bill.id = id_str + numeric_value.ToString();

            db.BILLs.Add(bill);
            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }
        public void Delete()
        {
            var delete_bill = db.BILLs.First(p => p.id == bill.id);

            db.BILLs.Remove(delete_bill);
            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_bill = db.BILLs.First(p => p.id == bill.id);

            edited_bill.id_sim = bill.id_sim;
            edited_bill.date_export = bill.date_export;
            edited_bill.invoice_date = bill.invoice_date;
            edited_bill.date_cut = bill.date_cut;
            edited_bill.postage = bill.postage;
            edited_bill.fare = bill.fare;
            edited_bill.status = bill.status;

            db.SaveChanges();

            db.Entry(bill).State = EntityState.Detached;
        }
        public void Pay()
        {
            try {
                var edited_bill = db.BILLs.First(p => p.id == bill.id);

                edited_bill.status = true;

                db.SaveChanges();

                db.Entry(bill).State = EntityState.Detached;
            }
            catch { }
            
            }
        public bool checkIfExist()
        {
            return db.BILLs.Any(b => b.id == bill.id && b.date_export.Value.Month == bill.date_export.Value.Month && b.date_export.Value.Year == bill.date_export.Value.Year);

        }
        public IEnumerable<BILL> SearchBy_CustomerName(string name)
        {
            if (db.BILLs.Any(c => c.SIM.CUSTOMER.name_cus.Contains(name)))
            {
                List<BILL> result = db.BILLs.Where(c => c.SIM.CUSTOMER.name_cus.Contains(name)).ToList();
                return result;
            }
            return null;
        }

        // Gửi thông báo cước phí hàng tháng cho khách hàng khi tạo bill
        public bool SendBillByEmail(string toMail, string name_customer)
        {
            MailMessage mail = new MailMessage("huykgit1998@gmail.com", toMail);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("huykgit1998@gmail.com", "Huy3612380");
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            mail.Subject = "Thông báo cước tháng - Dịch vụ viễn thông Nhóm 04";
            mail.IsBodyHtml = true;

            string htmlBody = @"
            <div style='float:left;'>
		        
		        <div style='float:left; width:100%; background-color:#ffffff; padding: 2% 2%; border:1px solid#4286f4;'>
			        <div style='float:left; width:100%; color:#cc0000; font-size:14px;'>Đây là email tự động từ hệ thống, vui lòng không phản hồi (reply) lại email này</div>
			        <div style='float:left; width:100%;'>
				        <p>
					        <strong>Kính gửi: " + name_customer + @"</strong>
					        <br /> 
				        </p>
			        </div>
			        <div style='float:left; width:100%; padding: 2% 2%;'>
				        <table style='border:3px solid #cc0000; width: 90%;'>
                            <tr>
						        <td>Ngày Lập Hóa Đơn:</td>
						        <td><span style='font-weight: bold;'>" + bill.invoice_date.ToString() + @"</span></td>
					        </tr>
					        <tr>
						        <td>Kì Sử Dụng:</td>
						        <td><span style='font-weight: bold;'><span style='font-weight: bold;'>" + bill.date_export.ToString() + @"</span></td>
					        </tr>					        
					        <tr>
						        <td>Tiền thuê bao hàng tháng:</td>
						        <td><span style='font-weight: bold;'>" + bill.postage.ToString() + @" VNĐ</span></td>
					        </tr>
					        <tr>
						        <td>Tổng tiền:</td>
						        <td><span style='font-weight: bold;'>" + bill.fare.ToString() + @"</span></td>
					        </tr>
				        </table>			
			        </div>
			        <div style='float:left; width:100%; padding: 2% 0%;' background-color:#ffffff; font-weight: bold;'>
				        Nếu quý khách có thắc mắc vấn đề gì có thể liên hệ qua <span style='color: #cc0000'> 0387134747 (huy nguyen) </span>.
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
        // Gửi thông báo cước phí hàng tháng cho khách hàng khi tạo bill
        public bool SendBillByEmail1(string toMail, string name_customer)
        {
            MailMessage mail = new MailMessage("huykgit1998@gmail.com", toMail);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("huykgit1998@gmail.com", "Huy3612380");
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            mail.Subject = "Thông báo đình chỉ cung cấp dịch vụ";
            mail.IsBodyHtml = true;

            string htmlBody = @"
            <div style='float:left;'>
		        
		        <div style='float:left; width:100%; background-color:#ffffff; padding: 2% 2%; border:1px solid#4286f4;'>
			        <div style='float:left; width:100%; color:#cc0000; font-size:14px;'>Đây là email tự động từ hệ thống, vui lòng không phản hồi (reply) lại email này</div>
			        <div style='float:left; width:100%;'>
				        <p>
					        <strong>Kính gửi: " + name_customer + @"</strong>
					        <br /> 
				        </p>
                        <p>
					        Tháng vừa rồi anh/chị chưa thanh toán cước phí sử dụng dịch vụ, vui lòng thanh toán để k bị cắt sim!
					        <br /> 
				        </p>
			        </div>
			        <div style='float:left; width:100%; padding: 2% 2%;'>
				        <table style='border:3px solid #cc0000; width: 90%;'>
                           
					        <tr>
						        <td>Kì Sử Dụng:</td>
						        <td><span style='font-weight: bold;'><span style='font-weight: bold;'>" + bill.date_export.ToString() + @"</span></td>
					        </tr>					        
					        <tr>
						        <td>Tiền thuê bao hàng tháng:</td>
						        <td><span style='font-weight: bold;'>" + bill.postage.ToString() + @" VNĐ</span></td>
					        </tr>
					        <tr>
						        <td>Tổng tiền:</td>
						        <td><span style='font-weight: bold;'>" + bill.fare.ToString() + @"</span></td>
					        </tr>
				        </table>			
			        </div>
			        <div style='float:left; width:100%; padding: 2% 0%;' background-color:#ffffff; font-weight: bold;'>
				        Nếu quý khách có thắc mắc vấn đề gì có thể liên hệ qua <span style='color: #cc0000'> 0387134747 (huy nguyen) </span>.
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

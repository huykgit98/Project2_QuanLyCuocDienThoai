using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BillDetails
    {
        public BillDetails() { }
        public BillDetails(string ID_SIM, DateTime? DATE_EXPORT, DateTime? DATE_CUT, int? POSTAGE, int? MINUTEUSED, int? FARE, bool? STATUS)
        {
            this.Id_sim = ID_SIM;
            this.Date_export = DATE_EXPORT;
            this.Date_cut = DATE_CUT;
            this.Postage = POSTAGE;
            this.Minute_used = MINUTEUSED;
            this.Fare = FARE;
            this.Status = STATUS;
        }
        public string Id_sim { get; set; }
        public Nullable<System.DateTime> Date_export { get; set; }
        public Nullable<System.DateTime> Date_cut { get; set; }
        public Nullable<int> Postage { get; set; }
        public Nullable<int> Minute_used{ get; set; }
        public Nullable<int> Fare{ get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
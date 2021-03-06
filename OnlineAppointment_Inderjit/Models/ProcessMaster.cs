using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineAppointment_Inderjit.Models
{
    public class ProcessMaster
    {
        public int ID { get; set; }
        public int AppointmentMasterID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Cancel Date")]
        public Nullable<DateTime> ProcessDate { get; set; }
        public string Remarks { get; set; }

        public AppointmentMaster AppointmentMaster { get; set; }
    }
}
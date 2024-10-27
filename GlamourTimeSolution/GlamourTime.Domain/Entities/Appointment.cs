using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlamourTime.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int StylistId { get; set; }
        public int ServiceId { get; set; }
        public DateTime DateTime { get; set; }
        public bool Confirmed { get; set; }
    }

}

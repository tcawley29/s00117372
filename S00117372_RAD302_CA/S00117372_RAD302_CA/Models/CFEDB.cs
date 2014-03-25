using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using S00117372_RAD302_CA.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace S00117372_RAD302_CA.Models
{
    public class Leg
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string StartLocation { get; set; }

        [Required]
        public string FinishLocation { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FinishDate { get; set; }

        [DisplayName("Trip")]
        public int TripID { get; set; }

        public virtual ICollection<GuestReg> LegReg { get; set; }

        public virtual Trip Trip { get; set; }

    }

    public class Guest
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<GuestReg> LegReg { get; set; }
    }

    public class GuestReg
    {
        [Key]
        public int GuestRegistrationID { get; set; }
        public int LegID { get; set; }
        public int GuestID { get; set; }

        public virtual Leg Leg { get; set; }
        public virtual Guest Guest { get; set; }

    }

    public class Trip
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public int MinimumGuests { get; set; }

        public bool Viable { get; set; }

        public bool Complete { get; set; }

        public virtual ICollection<Leg> Legs { get; set; }
    }
}
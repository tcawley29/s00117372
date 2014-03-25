using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace S00117372_RAD302_CA.Models
{
    public class TravelEntities : DbContext
    {
        public DbSet<Leg> Legs { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<GuestReg> GuestRegistrations { get; set; }

        public TravelEntities()
            : base("S00117372_RAD302_Travel")
        {
            //Database.SetInitializer(new TravelSeed());
        }
    }
}
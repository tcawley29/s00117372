using S00117372_RAD302_CA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace S00117372_RAD302_CA.Models
{
    public class TravelSeed:DropCreateDatabaseAlways<TravelEntities>
    {
        protected override void Seed(TravelEntities db)
        {

             var trips = new List<Trip>
            {
                new Trip{Name = "New York", StartDate = new DateTime(2014, 04, 14),FinishDate = new DateTime(2014, 04, 26),MinimumGuests = 3, Viable = true, Complete = true},
                new Trip{Name = "Chicago", StartDate = new DateTime(2014, 07, 01),FinishDate = new DateTime(2014, 07, 13),MinimumGuests = 5, Viable = false, Complete = true},
                new Trip{Name = "Miami", StartDate = new DateTime(2014, 06, 27),FinishDate = new DateTime(2014, 07, 06),MinimumGuests = 7, Viable = true, Complete = false},
                new Trip{Name = "Asia", StartDate = new DateTime(2014, 09, 01),FinishDate = new DateTime(2014, 09, 20),MinimumGuests = 4, Viable = true, Complete = true},
                new Trip{Name = "Europe", StartDate = new DateTime(2014, 12, 01),FinishDate = new DateTime(2014, 08, 15),MinimumGuests = 9, Viable = false, Complete = true},          
            };
            
            trips.ForEach(t=>db.Trips.Add(t));
            db.SaveChanges();

            var legs = new List<Leg>
            {
                 // Legs For Trip 1
                 new Leg {StartLocation = "Dublin", StartDate = new DateTime(2014, 04, 14), FinishLocation = "Newark", FinishDate = new DateTime(2014, 04, 16),TripID = 1},
                 new Leg {StartLocation = "Newark", StartDate = new DateTime(2014, 04, 16), FinishLocation = "Bronx", FinishDate = new DateTime(2014, 04, 18), TripID = 1},
                 new Leg {StartLocation = "Bronx", StartDate = new DateTime(2014, 04, 18), FinishLocation = "Yonkers", FinishDate = new DateTime(2014, 04, 20), TripID = 1},
                 new Leg {StartLocation = "Yonkers", StartDate = new DateTime(2014, 04, 20), FinishLocation = "Rochester", FinishDate = new DateTime(2014, 04, 22),TripID = 1},
                 new Leg {StartLocation = "Rochester", StartDate = new DateTime(2014, 04, 22), FinishLocation = "White Plains", FinishDate = new DateTime(2014, 04, 24), TripID = 1},
                 new Leg {StartLocation = "White Plains", StartDate = new DateTime(2014, 04, 24), FinishLocation = "Long Beach", FinishDate = new DateTime(2014, 04, 26), TripID = 1},
                 // Legs For Trip 2
                 new Leg {StartLocation = "Shannon", StartDate = new DateTime(2014, 07, 01),FinishLocation = "Dublin",FinishDate = new DateTime(2014, 07, 03), TripID = 2},
                 new Leg {StartLocation = "Dublin", StartDate = new DateTime(2014, 07, 03),FinishLocation = "Evanstown",FinishDate = new DateTime(2014, 07, 05), TripID = 2},
                 new Leg {StartLocation = "Evanstown", StartDate = new DateTime(2014, 07, 05),FinishLocation = "Dunning",FinishDate = new DateTime(2014, 07, 07), TripID = 2},
                 new Leg {StartLocation = "Dunning", StartDate = new DateTime(2014, 07, 07),FinishLocation = "Niles",FinishDate = new DateTime(2014, 07, 09), TripID = 2},
                 new Leg {StartLocation = "Niles", StartDate = new DateTime(2014, 07, 09),FinishLocation = "Belwood",FinishDate = new DateTime(2014, 07, 11), TripID = 2},
                 new Leg {StartLocation = "Belwood", StartDate = new DateTime(2014, 07, 11),FinishLocation = "Avondale",FinishDate = new DateTime(2014, 07, 13), TripID = 2},
                 // Legs For Trip 3
                 new Leg {StartLocation = "Knock", StartDate = new DateTime(2014, 06, 27),FinishLocation = "Dublin",FinishDate = new DateTime(2014, 06, 28), TripID = 3},
                 new Leg {StartLocation = "Dublin", StartDate = new DateTime(2014, 06, 28),FinishLocation = "Liverpool",FinishDate = new DateTime(2014, 06, 30), TripID = 3},
                 new Leg {StartLocation = "Liverpool", StartDate = new DateTime(2014, 06, 30),FinishLocation = "Florida",FinishDate = new DateTime(2014, 07, 01), TripID = 3},
                 new Leg {StartLocation = "Florida", StartDate = new DateTime(2014, 07, 01),FinishLocation = "Doral",FinishDate = new DateTime(2014, 07, 02), TripID = 3},
                 new Leg {StartLocation = "Doral", StartDate = new DateTime(2014, 07, 02),FinishLocation = "Gladeview",FinishDate = new DateTime(2014, 07, 04), TripID = 3},
                 new Leg {StartLocation = "Gladeview", StartDate = new DateTime(2014, 07, 04),FinishLocation = "Little Haiti",FinishDate = new DateTime(2014, 07, 06), TripID = 3},
                 // Legs For Trip 4
                 new Leg {StartLocation = "Knock", StartDate = new DateTime(2014, 09, 01),FinishLocation = "Dublin",FinishDate = new DateTime(2014, 09, 02), TripID = 4},
                 new Leg {StartLocation = "Dublin", StartDate = new DateTime(2014, 09, 02),FinishLocation = "Liverpool",FinishDate = new DateTime(2014, 09, 03), TripID = 4},
                 new Leg {StartLocation = "Liverpool", StartDate = new DateTime(2014, 09, 03),FinishLocation = "Shenzen",FinishDate = new DateTime(2014, 09, 05), TripID = 4},
                 new Leg {StartLocation = "Shenzen", StartDate = new DateTime(2014, 09, 05),FinishLocation = "Hong Kong",FinishDate = new DateTime(2014, 09, 10), TripID = 4},
                 new Leg {StartLocation = "Hong Kong", StartDate = new DateTime(2014, 09, 10),FinishLocation = "Thailand",FinishDate = new DateTime(2014, 09, 15), TripID = 4},
                 new Leg {StartLocation = "Thailand", StartDate = new DateTime(2014, 09, 15),FinishLocation = "Taiwan",FinishDate = new DateTime(2014, 09, 20), TripID = 4},
                 // Legs For Trip 5
                 new Leg {StartLocation = "Knock", StartDate = new DateTime(2014, 12, 01),FinishLocation = "Dublin",FinishDate = new DateTime(2014, 12, 02), TripID = 5},
                 new Leg {StartLocation = "Dublin", StartDate = new DateTime(2014, 12, 02),FinishLocation = "Liverpool",FinishDate = new DateTime(2014, 12, 03), TripID = 5},
                 new Leg {StartLocation = "Liverpool", StartDate = new DateTime(2014, 12, 03),FinishLocation = "Bourgas",FinishDate = new DateTime(2014, 12, 04), TripID = 5},
                 new Leg {StartLocation = "Bourgas", StartDate = new DateTime(2014, 12, 04),FinishLocation = "Palma",FinishDate = new DateTime(2014, 12, 09), TripID = 5},
                 new Leg {StartLocation = "Palma", StartDate = new DateTime(2014, 12, 09),FinishLocation = "Ibiza",FinishDate = new DateTime(2014, 12, 14), TripID = 5},
                 new Leg {StartLocation = "Ibiza", StartDate = new DateTime(2014, 12, 14),FinishLocation = "Faro",FinishDate = new DateTime(2014, 12, 19), TripID = 5}
            };

            legs.ForEach(leg=>db.Legs.Add(leg));
            db.SaveChanges();

            var guests = new List<Guest>
            {
                new Guest {FirstName = "Tommy"},
                new Guest {FirstName = "Paul"},
                new Guest {FirstName = "John"},
                new Guest {FirstName = "Kevin"},
                new Guest {FirstName = "Pat"},
                new Guest {FirstName = "Dermot"},
                new Guest {FirstName = "Jimmy"},
                new Guest {FirstName = "Ann Marie"},
                new Guest {FirstName = "Margaret"},
                new Guest {FirstName = "Kieran"},
                new Guest {FirstName = "Eileen"},
                new Guest {FirstName = "Declan"},
                new Guest {FirstName = "Steve"},
                new Guest {FirstName = "Damien"},
                new Guest {FirstName = "Treasa"},
                new Guest {FirstName = "Patricia"},
                new Guest {FirstName = "James"},
                new Guest {FirstName = "Gareth"},
                new Guest {FirstName = "Owen"},
                new Guest {FirstName = "Sean"},
                new Guest {FirstName = "Olivia"},
                new Guest {FirstName = "Emma"}
                
            };

            guests.ForEach(g=>db.Guests.Add(g));
            db.SaveChanges();

            var legReg = new List<GuestReg>
            {
                new GuestReg {LegID = 1, GuestID = 1},
                new GuestReg {LegID = 2, GuestID = 2},
                new GuestReg {LegID = 3, GuestID = 3},
                new GuestReg {LegID = 4, GuestID = 4},
                new GuestReg {LegID = 5, GuestID = 5},
                new GuestReg {LegID = 6, GuestID = 6},
                new GuestReg {LegID = 7, GuestID = 7},
                new GuestReg {LegID = 8, GuestID = 8},
                new GuestReg {LegID = 9, GuestID = 9},
                new GuestReg {LegID = 10, GuestID = 10},
                new GuestReg {LegID = 11, GuestID = 11},
                new GuestReg {LegID = 12, GuestID = 12},
                new GuestReg {LegID = 13, GuestID = 13},
                new GuestReg {LegID = 14, GuestID = 14},
                new GuestReg {LegID = 15, GuestID = 15},
                new GuestReg {LegID = 16, GuestID = 16},
                new GuestReg {LegID = 17, GuestID = 17},
                new GuestReg {LegID = 18, GuestID = 18},
                new GuestReg {LegID = 19, GuestID = 19},
                new GuestReg {LegID = 20, GuestID = 20}
            };

            legReg.ForEach(legR=>db.GuestRegistrations.Add(legR));
            db.SaveChanges();

        }   
}
}



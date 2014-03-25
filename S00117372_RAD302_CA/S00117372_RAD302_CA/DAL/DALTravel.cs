using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using S00117372_RAD302_CA.Models;

namespace S00117372_RAD302_CA.DAL
{
    public class DALTravel:DALITravel
    {
        public TravelEntities Entities;

        public DALTravel()
        {
            Entities= new TravelEntities();
        }
        public IQueryable<Trip> GetAllTrips()
        {
            return Entities.Trips.OrderBy(t=>t.StartDate);
        }

        public Trip GetTrip(int? tripId)
        {
            return Entities.Trips.Find(tripId);
     
        }

        public Leg GetLeg(int legId)
        {
            return Entities.Legs.Find(legId);
        }

        public IEnumerable<Guest> GetGuestsOnLeg(int legId)
        {
            return Entities.Legs.Find(legId).LegReg.Select(legR => legR.Guest);

        }

        public IQueryable<Leg> GetLegsForTrip(int tripId)
        {
            return Entities.Legs.Where(t=>t.TripID == tripId).SortBy("StartDate");            
        }

        public int GetNoGuestsOnTrip(int tripId)
        {
            var guestReg = Entities.GuestRegistrations.Where(r => r.Leg.TripID == tripId);
            var guests = guestReg.Select(g => g.GuestID).Distinct();
            var numbeofGuests = 0;
            foreach (var guest in guests)
            {

                if (guestReg.Where(g => g.GuestID == guest).Distinct().Count() >= 2)
                    numbeofGuests++;

            }
            return numbeofGuests;
        }

        public IQueryable<Guest> GetGuests()
        {
            return Entities.Guests.OrderBy(g=>g.FirstName);
        }

        public IQueryable<GuestReg> GetGuestRegistrationsByLegAndGuest(int legId, int guestId)
        {
            return Entities.GuestRegistrations.Where(r => r.LegID == legId && r.GuestID == guestId);
        }

        public void AddTrip(Trip trip)
        {
            Entities.Trips.Add(trip);
            Entities.SaveChanges();
        }

        public void AddLeg(Leg leg)
        {
            Entities.Legs.Add(leg);
            Entities.SaveChanges();
        }

        public void UpdateTrip(Trip trip)
        {
            Entities.Trips.Attach(trip);
            Entities.Entry(trip).State= EntityState.Modified;
            Entities.SaveChanges();
        }

        public void AddGuestRegistration(GuestReg registration)
        {
            Entities.GuestRegistrations.Add(registration);
            Entities.SaveChanges();
        }

        public void Dispose()
        {
            Entities.Dispose();
        }
    }
}
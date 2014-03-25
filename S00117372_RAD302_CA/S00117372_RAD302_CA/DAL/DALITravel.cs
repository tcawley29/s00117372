using System;
using System.Collections.Generic;
using System.Linq;
using S00117372_RAD302_CA.Models;

namespace S00117372_RAD302_CA.DAL
{
    public interface DALITravel :IDisposable
    {
        IQueryable <Trip> GetAllTrips();
        Trip GetTrip(int? tripId);
        Leg GetLeg(int legId);
        IEnumerable<Guest> GetGuestsOnLeg(int legId);
        IQueryable <Leg> GetLegsForTrip(int tripId);

        int GetNoGuestsOnTrip(int tripId);
        IQueryable<Guest> GetGuests();
        IQueryable<GuestReg> GetGuestRegistrationsByLegAndGuest(int legId, int guestId); 
        void AddTrip(Trip trip);
        void AddLeg(Leg leg);
        void UpdateTrip(Trip trip);
        void AddGuestRegistration(GuestReg registration);
    }

}

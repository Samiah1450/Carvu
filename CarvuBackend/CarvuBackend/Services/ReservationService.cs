using CarvuBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Services
{
    public class ReservationService : IReservationService
    {
        private readonly CarvuDbContext _carvuDbContext;
        
        public ReservationService(CarvuDbContext carvuDbContext)
        {
            _carvuDbContext = carvuDbContext;
        }

        public IEnumerable<Reservation> GetReservations()
        {
            return _carvuDbContext.Reservations.ToList();
        }

        public Reservation GetReservation(Guid id)
        {
            return _carvuDbContext.Reservations.Where(x => x.Id == id).FirstOrDefault();
        }

        public Reservation AddReservation(Reservation reservation)
        {
            if (reservation == null)
            {
                throw new Exception("Reservation info cannot be empty.");
            }

            var newReservation = _carvuDbContext.Reservations.Add(reservation).Entity;
            _carvuDbContext.SaveChanges();
            return newReservation;
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
            if (reservation == null)
            {
                throw new Exception("Reservation info cannot be empty.");
            }

            var reservationToUpdate = _carvuDbContext.Reservations.Where(x => x.Id == reservation.Id).FirstOrDefault();
            if (reservationToUpdate == null)
            {
                throw new Exception("The reservation to update was not found.");
            }

            reservationToUpdate.StartDate = reservation.StartDate;
            reservationToUpdate.EndDate = reservation.EndDate;
            reservationToUpdate.Cost = reservation.Cost;

            _carvuDbContext.SaveChanges();
            return reservationToUpdate;
        }
        
        public void DeleteReservation(Guid id)
        {
            var reservationToDelete = _carvuDbContext.Reservations.Where(x => x.Id == id).FirstOrDefault();
            if (reservationToDelete == null)
            {
                throw new Exception("The reservation to delete was not found in the database.");
            }

            _carvuDbContext.Reservations.Remove(reservationToDelete);
            _carvuDbContext.SaveChanges();
        }
    }
}

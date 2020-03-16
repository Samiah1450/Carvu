using CarvuBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Services
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetReservations();
        Reservation GetReservation(Guid id);
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(Guid id);
    }
}

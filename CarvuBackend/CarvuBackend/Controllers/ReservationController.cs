using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvuBackend.Models;
using CarvuBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarvuBackend.Controllers
{
    [Route("api/reservation")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public IActionResult GetReservations()
        {
            var result = _reservationService.GetReservations();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetReservation(Guid id)
        {
            var result = _reservationService.GetReservation(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddReservation([FromBody] Reservation reservation)
        {
            var result = _reservationService.AddReservation(reservation);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateReservation([FromBody] Reservation reservation)
        {
            var result = _reservationService.UpdateReservation(reservation);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReservation(Guid id)
        {
            _reservationService.DeleteReservation(id);
            return Ok();
        }
    }
}
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
    [Route("api/businessowner")]
    [ApiController]
    public class BusinessOwnerController : ControllerBase
    {
        private readonly IBusinessOwnerService _businessOwnerService;

        public BusinessOwnerController(IBusinessOwnerService businessOwnerService)
        {
            _businessOwnerService = businessOwnerService;
        }

        [HttpGet]
        public IActionResult GetBusinessOwner([FromBody] BusinessOwner credentials)
        {
            var result = _businessOwnerService.GetBusinessOwner(credentials);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddBusinessOwner([FromBody] BusinessOwner businessOwner)
        {
            var result = _businessOwnerService.AddBusinessOwner(businessOwner);
            return Ok(result);
        }
    }
}
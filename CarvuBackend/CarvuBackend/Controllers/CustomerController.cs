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
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var result = _customerService.GetCustomers();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(Guid id)
        {
            var result = _customerService.GetCustomer(id);
            return Ok(result);
        }

        [HttpPost] 
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            var result = _customerService.AddCustomer(customer);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            var result = _customerService.UpdateCustomer(customer);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(Guid id)
        {
            _customerService.DeleteCustomer(id);
            return Ok();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SVTService.Module;
using SVTService.Repository;

namespace SVTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        // GET: api/Service
        [HttpGet]
        public IActionResult Get()
        {
            var services = _serviceRepository.GetSVTServices();
            return new OkObjectResult(services);
            //return services;
        }

        // GET: api/Service/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var services = _serviceRepository.GetSVTServicesByID(id);
            return new OkObjectResult(services);
        }

        // POST: api/Service
        [HttpPost]
        public IActionResult Post([FromBody] SVService services)
        {
            using (var scope = new TransactionScope())
            {
                _serviceRepository.InsertSVTService(services);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = services.ServiceID }, services);
            }
        }

        // PUT: api/Service/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] SVService services)
        {
            if (services != null)
            {
                using (var scope = new TransactionScope())
                {
                    _serviceRepository.UpdateSVTService(services);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serviceRepository.DeleteSVTService(id);
            return new OkResult();
        }
    }
}

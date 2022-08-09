using Liquid.WebApi.Http.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjectLiquid.Domain.Entities;
using ProjectLiquid.Domain.Handlers.Customer.Create;
using ProjectLiquid.Domain.Handlers.Customer.Remove;
using ProjectLiquid.Domain.Handlers.Customer.Read;
using ProjectLiquid.Domain.Handlers.Customer.Update;
using ProjectLiquid.Domain.Handlers.Customer.List;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace ProjectLiquid.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : LiquidControllerBase
    {
        public CustomerController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var response = await ExecuteAsync(new ReadCustomerQuery(id));

            if (response.Data == null) return NotFound();

            return Ok(response.Data);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var response = await ExecuteAsync(new ListCustomerQuery());

            if (response.Data == null) return NotFound();

            return Ok(response.Data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] CustomerEntity entity)
        {
            await ExecuteAsync(new CreateCustomerCommand(entity));

            return CreatedAtRoute("", new { id = entity.Id }, entity);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Put([FromBody] CustomerEntity entity)
        {
            var response = await ExecuteAsync(new UpdateCustomerCommand(entity));

            if (response.Data == null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await ExecuteAsync(new RemoveCustomerCommand(id));

            if (response.Data == null) return NotFound();

            return NoContent();
        }
    }
}
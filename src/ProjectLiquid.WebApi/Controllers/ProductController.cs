using Liquid.WebApi.Http.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjectLiquid.Domain.Entities;
using ProjectLiquid.Domain.Handlers.Product.Create;
using ProjectLiquid.Domain.Handlers.Product.Remove;
using ProjectLiquid.Domain.Handlers.Product.Read;
using ProjectLiquid.Domain.Handlers.Product.Update;
using ProjectLiquid.Domain.Handlers.Product.List;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace ProjectLiquid.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : LiquidControllerBase
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await ExecuteAsync(new ReadProductQuery(id));

            if (response.Data == null) return NotFound();

            return Ok(response.Data);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var response = await ExecuteAsync(new ListProductQuery());

            if (response.Data == null) return NotFound();

            return Ok(response.Data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] ProductEntity entity)
        {
            await ExecuteAsync(new CreateProductCommand(entity));

            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Put([FromBody] ProductEntity entity)
        {
            var response = await ExecuteAsync(new UpdateProductCommand(entity));

            if (response.Data == null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var response = await ExecuteAsync(new RemoveProductCommand(id));

            if (response.Data == null) return NotFound();

            return NoContent();
        }
    }
}
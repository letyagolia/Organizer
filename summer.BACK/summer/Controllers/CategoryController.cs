using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using summer.Domain.Dto;
using summer.Domain.Repositories;

namespace summer.Controllers
{
    [Route("api/[controller]")]

  
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repo;
        public CategoryController(ICategoryRepository repo)
        {
            _repo = repo;
        }

        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _repo.GetAllAsync());
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                return Ok(await _repo.GetByIdAsync(id));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryDto item)
        {
            try
            {
                return Ok(await _repo.CreateAsync(item));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CategoryDto item)
        {
            try
            {
                return Ok(await _repo.UpdateAsync(item));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                return Ok(await _repo.DeleteAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}

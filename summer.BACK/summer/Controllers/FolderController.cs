using Microsoft.AspNetCore.Mvc;
using summer.Domain.Dto;
using summer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace summer.API.Controllers
{
    [Route("api/[controller]")]
    public class FolderController : Controller
    {
        private readonly IFolderRepository _repo;

        public FolderController(IFolderRepository repo)
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

        [HttpGet("category/{id}")]
        public async Task<IActionResult> GetByCategory(Guid id)
        {
            try
            {
                return Ok(await _repo.GetByCategoryIdAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FolderDto item)
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
        public async Task<IActionResult> Put([FromBody] FolderDto item)
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

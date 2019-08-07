using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using summer.Core.EF;
using summer.Domain.Converters;
using summer.Domain.Dto;
using summer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace summer.Core.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly TasksContext _context;
        

        public CategoryRepository(TasksContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            return CategoryConverter.Convert(await _context.Categories.ToListAsync());
        }

        public async Task<CategoryDto> GetByIdAsync(Guid id)
        {
            return CategoryConverter.Convert(await _context.Categories.FindAsync(id));
        }

        public async Task<CategoryDto> CreateAsync(CategoryDto item)
        {
            var result = _context.Categories.Add(CategoryConverter.Convert(item));
            await _context.SaveChangesAsync();
            return CategoryConverter.Convert(result.Entity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var ctg = await _context.Categories.FindAsync(id);
            if (ctg == null)
                return false;
            _context.Categories.Remove(ctg);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(CategoryDto item)
        {
            if (item == null)
                return false;
            _context.Categories.Update(CategoryConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

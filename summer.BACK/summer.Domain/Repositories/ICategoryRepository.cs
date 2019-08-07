using summer.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace summer.Domain.Repositories
{
    public interface ICategoryRepository    //работа с базой данных
    {
        Task<List<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetByIdAsync(Guid id);
        Task<CategoryDto> CreateAsync(CategoryDto item);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(CategoryDto item);
    }
}

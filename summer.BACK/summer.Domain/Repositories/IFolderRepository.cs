using summer.Domain.Dto;
using summer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace summer.Domain.Repositories
{
    public interface IFolderRepository
    {
        Task<List<FolderDto>> GetAllAsync();
        Task<FolderDto> GetByIdAsync(Guid id);
        Task<List<Folder>> GetByCategoryIdAsync(Guid id);
        Task<FolderDto> CreateAsync(FolderDto item);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(FolderDto item);

    }
}

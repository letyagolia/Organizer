using Microsoft.EntityFrameworkCore;
using summer.Core.EF;
using summer.Domain.Converters;
using summer.Domain.Dto;
using summer.Domain.Entities;
using summer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summer.Core.Repositories
{
    public class FolderRepository: IFolderRepository
    {
        private readonly TasksContext _context;

        public FolderRepository(TasksContext context)
        {
            _context = context;
        }

        public async Task<List<FolderDto>> GetAllAsync()
        {
            return FolderConverter.Convert(await _context.Folders.ToListAsync());
        }

        public async Task<FolderDto> GetByIdAsync(Guid id)
        {
            return FolderConverter.Convert(await _context.Folders.FindAsync(id));
        }

        public async Task<List<Folder>> GetByCategoryIdAsync(Guid id)
        {
            return await _context.Folders.Where(b => b.CategoryId == id).ToListAsync();
        }

        public async Task<FolderDto> CreateAsync(FolderDto item)
        {
            var result = _context.Folders.Add(FolderConverter.Convert(item));
            await _context.SaveChangesAsync();
            return FolderConverter.Convert(result.Entity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var fld = await _context.Folders.FindAsync(id);
            if (fld == null)
                return false;
            _context.Folders.Remove(fld);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(FolderDto item)
        {
            if (item == null)
                return false;
            _context.Folders.Update(FolderConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

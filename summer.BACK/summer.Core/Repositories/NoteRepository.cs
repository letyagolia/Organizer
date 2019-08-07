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
    public class NoteRepository: INoteRepository
    {
        private readonly TasksContext _context;

        public NoteRepository(TasksContext context)
        {
            _context = context;
        }

        public async Task<List<NoteDto>> GetAllAsync()
        {
            return NoteConverter.Convert(await _context.Notes.ToListAsync());
        }

        public async Task<NoteDto> GetByIdAsync(Guid id)
        {
            return NoteConverter.Convert(await _context.Notes.FindAsync(id));
        }

        public async Task<List<Note>> GetByFolderIdAsync(Guid id)
        {
            return await _context.Notes.Where(q => q.FolderId == id).ToListAsync();
        }

        public async Task<NoteDto> CreateAsync(NoteDto item)
        {
            var result = _context.Notes.Add(NoteConverter.Convert(item));
            await _context.SaveChangesAsync();
            return NoteConverter.Convert(result.Entity);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note == null)
                return false;
            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(NoteDto item)
        {
            if (item == null)
                return false;
            _context.Notes.Update(NoteConverter.Convert(item));
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

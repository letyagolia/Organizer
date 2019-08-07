using summer.Domain.Dto;
using summer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace summer.Domain.Repositories
{
    public interface INoteRepository
    {
        Task<List<NoteDto>> GetAllAsync();
        Task<NoteDto> GetByIdAsync(Guid id);
        Task<List<Note>> GetByFolderIdAsync(Guid id);
        Task<NoteDto> CreateAsync(NoteDto item);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(NoteDto noteDto);
    }
}

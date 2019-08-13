using System;
using System.Collections.Generic;
using System.Text;

namespace summer.Domain.Dto
{
    public class FolderDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto CategoryDto { get; set; }
        public virtual List<NoteDto> Notes { get; set; }
    }
}

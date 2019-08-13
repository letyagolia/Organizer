using summer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace summer.Domain.Dto
{
    public class NoteDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Importance { get; set; }
        public bool Done { get; set; }
        public FolderDto FolderDto { get; set; }
        public Guid FolderId { get; set; }
    }
}

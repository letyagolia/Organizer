using System;
using System.Collections.Generic;
using System.Text;

namespace summer.Domain.Entities
{
    public class Folder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public virtual List<Note> Notes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace summer.Domain.Dto
{
    public class CategoryDto
    {
        public Guid ID { get; set; }   
        public string Name { get; set; }
        public virtual List<FolderDto> FoldersDto { get; set; }
    }
}

using summer.Domain.Dto;
using summer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace summer.Domain.Converters
{
    public static class FolderConverter
    {
        public static Folder Convert(FolderDto folder)
        {
            return new Folder
            {
                Id = folder.Id,
                Name = folder.Name,
                CategoryId = folder.CategoryId
            };
        }

        public static FolderDto Convert(Folder folder)
        {
            return new FolderDto
            {
                Id = folder.Id,
                Name = folder.Name,
                CategoryId = folder.CategoryId
            };
        }

        public static List<Folder> Convert(List<FolderDto> folders)
        {
            return folders.Select(a => Convert(a)).ToList();
        }

        public static List<FolderDto> Convert(List<Folder> folders)
        {
            return folders.Select(a => Convert(a)).ToList();
        }
    }
}

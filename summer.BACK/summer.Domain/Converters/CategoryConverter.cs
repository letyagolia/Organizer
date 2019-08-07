using summer.Domain.Dto;
using summer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace summer.Domain.Converters
{
    public static class CategoryConverter
    {
        public static Category Convert(CategoryDto ctg)
        {
            return new Category
            {
                ID = ctg.ID,
                Name = ctg.Name
            };
        }

        public static CategoryDto Convert(Category ctg)
        {
            return new CategoryDto
            {
                ID = ctg.ID,
                Name = ctg.Name
            };
        }

        public static List<Category> Convert(List<CategoryDto> dtos)
        {
            return dtos.Select(a => Convert(a)).ToList();
        }

        public static List<CategoryDto> Convert(List<Category> dtos)
        {
            return dtos.Select(a => Convert(a)).ToList();
        }
    }
}

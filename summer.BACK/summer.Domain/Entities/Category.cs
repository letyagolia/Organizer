﻿using System;
using System.Collections.Generic;
using System.Text;

namespace summer.Domain.Entities
{
    public class Category
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        List<Folder> Folders { get; set; }
    }
}
             




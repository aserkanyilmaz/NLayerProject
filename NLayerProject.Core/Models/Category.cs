using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerProject.Core.Models
{
   internal class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public int categoryId { get; set; }

        public string categoryName { get; set; }

        public bool isDeleted { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}

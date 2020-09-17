using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Core.Models
{
    class Product
    {
        public int productId { get; set; }

        public string productName { get; set; }

        public int stock { get; set; }

        public decimal price { get; set; }

        public int categoryId { get; set; }

        public bool isDeleted { get; set; }
        
        public string innerBarcode { get; set; }

        public virtual Category Category { get; set; }

    }
}

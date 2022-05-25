using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        [Key]
        public int ID { get; set; }


        [MaxLength(120),Required]
        public string ProductName { get; set; }


        public long price { get; set; }
    }
}

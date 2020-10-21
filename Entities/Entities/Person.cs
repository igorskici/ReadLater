using ReadLater.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLater.Entities
{
    public class Person : EntityBase
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; } 
    }
}

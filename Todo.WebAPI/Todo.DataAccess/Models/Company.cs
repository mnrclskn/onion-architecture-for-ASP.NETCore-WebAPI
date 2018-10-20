using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;using Todo.Core.Entities;

namespace Todo.DataAccess.Models
{
    public class Company:IEntity
    {
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}

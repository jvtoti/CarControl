using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarControl.Models
{
    public class MotoristaContext : DbContext
    {
        public MotoristaContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<CarControl.Models.Motorista> Motoristas { get; set; }
    }
}
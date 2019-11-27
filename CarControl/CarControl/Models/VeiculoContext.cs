using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarControl.Models
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<CarControl.Models.Veiculo> Veiculos { get; set; }
    }
}
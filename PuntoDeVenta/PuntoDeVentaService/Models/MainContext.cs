using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PuntoDeVentaService.Models
{
    public class MainContext : DbContext
    {
        public MainContext() : base(nameOrConnectionString: "prueba") { }

        public System.Data.Entity.DbSet<MainService.Models.Proveedor> Proveedors { get; set; }
    }
}
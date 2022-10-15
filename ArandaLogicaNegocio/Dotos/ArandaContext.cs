using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using ArandaLogicaNegocio.Modelos;

namespace ArandaLogicaNegocio.Dotos
{
    public class ArandaContext : DbContext
    {
        public ArandaContext() : base("Server=PC-CARSEPE;Database=db_aranda;User ID=sa;Password=123456;Integrated Security=True")
        {
                
        }   
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }

        public static ArandaContext Create()
        {
            return new ArandaContext();
        }
    }
}

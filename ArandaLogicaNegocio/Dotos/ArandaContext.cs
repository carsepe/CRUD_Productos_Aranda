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
        private static ArandaContext arandaContext = null;
        public ArandaContext() 
             : base("ArandaContext")
        {
                 
        }   
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }

        public static ArandaContext Create()
        {
            //if (arandaContext == null) 
            //    arandaContext = new ArandaContext();
                
            return new ArandaContext();            
        }
    }
}

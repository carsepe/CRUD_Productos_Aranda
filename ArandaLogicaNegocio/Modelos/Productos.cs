using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.Modelos
{
    [Table("Productos", Schema = "dbo")]
    public class Productos
    {
        [Key]
        public int pro_id { get; set; }
        public string pro_nombre { get; set; }
        public string pro_descripcion { get; set; }
        
        public int pro_cat_id { get; set; }
        public string pro_imagen { get; set; }

    }
}

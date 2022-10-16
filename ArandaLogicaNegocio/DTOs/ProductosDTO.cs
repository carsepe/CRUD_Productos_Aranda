using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.DTOs
{
    public class ProductosDTO
    {
        //[Required(ErrorMessage ="El campo ID es requerido")]
        public int pro_id { get; set; }

        [Required(ErrorMessage = "El capo nombre es requerido")]
        [StringLength(50)]
        public string pro_nombre { get; set; }

        [StringLength(250)]
        public string pro_descripcion { get; set; }

        [Required(ErrorMessage = "El campo ID categoria es requerido")]
        public int pro_cat_id { get; set; }

        [StringLength(250)]
        public string pro_imagen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.DTOs
{
    public class CategoriasDTO
    {
        //[Required(ErrorMessage = "El campo ID es requerido")]
        //public int cat_id { get; set; }

        [Required(ErrorMessage = "El capo nombre es requerido")]
        [StringLength(50)]
        public string cat_nombre { get; set; }

        [StringLength(250)]
        public string cat_descripcion { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.Modelos
{
    [Table("Categorias", Schema = "dbo")]
    public class Categorias
    {
        [Key]
        public int cat_id { get; set; }
        public string cat_nombre { get; set; }
        public string cat_descripcion { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace ArandaLogicaNegocio.Modelos
{
    [Table("Productos", Schema = "dbo")]
    public class CategoriasBase
    {

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
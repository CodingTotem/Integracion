using System.ComponentModel.DataAnnotations.Schema;


namespace Models.Entities
{

    [Table("Marca")]
    public class Marca
    {

        public int MarcaId { get; set; }

        public string Nombre { get; set; }
        
    }

}
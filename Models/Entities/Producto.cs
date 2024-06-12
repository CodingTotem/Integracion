using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string? NombreProducto { get; set; }
        public string? CategoriaId { get; set; }
        public string? MarcaId { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }


        [ForeignKey("MarcaId")]
        public Marca? Marca { get; set; }
        public PrecioOferta Promocion { get; set; }
    }
}
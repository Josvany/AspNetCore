using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Models
{
    public class Categoria
    {
        [Key]
        public Guid categoriaIntId { get; set; }
        [Required (ErrorMessage ="Requerido")]
        public string categoriaName { get; set; }
        public string catgoriaDescription { get; set; }
        public bool categoriaStatus { get; set; }

    }
}

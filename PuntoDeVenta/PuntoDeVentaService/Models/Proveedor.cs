using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MainService.Models
{
    [Table("TB_CAT_PROVEEDOR")]
    public class Proveedor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(256)]
        public string Nombre { get; set; }
        public int TelCasa { get; set; }
        public int TelMovil { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(30)]
        public string RFC { get; set; }
    }
}
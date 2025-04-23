using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblio.Models
{
    public class Livre
    {
        [Key]
        public int LivreID { get; set; } // Primary Key

        [Required]
        public string Titre { get; set; }

        public int DatePublication { get; set; }

        public int Stock { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Prix { get; set; }

        [ForeignKey("Auteur")]
        public int AuteurID { get; set; } // Foreign Key

        [ForeignKey("Categorie")]
        public int CategorieID { get; set; } // Foreign Key

        // Navigation properties
        public Auteur Auteur { get; set; } // Navigation to Auteur

        public Categorie Categorie { get; set; } // Navigation to Categorie
    }
}

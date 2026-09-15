using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HeroesWeb.Models;

public partial class Heroes
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    [Display(Name = "Identidad secreta")]
    public string? IdentidadSecreta { get; set; }

    [StringLength(50)]
    public string? Ciudad { get; set; }

    [InverseProperty("Heroe")]
    public virtual ICollection<SuperPoderes> SuperPoderes { get; set; } = new List<SuperPoderes>();
}

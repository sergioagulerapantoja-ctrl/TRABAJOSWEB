using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HeroesWeb.Models;

public partial class SuperPoderes
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;

    [StringLength(500)]
    [Display(Name = "Descripción")]
    public string? Descripcion { get; set; }

    [Display(Name = "Héroe")]
    public int HeroeId { get; set; }

    [ForeignKey("HeroeId")]
    [InverseProperty("SuperPoderes")]
    [Display(Name = "Héroe")]
    public virtual Heroes Heroe { get; set; } = null!;
}

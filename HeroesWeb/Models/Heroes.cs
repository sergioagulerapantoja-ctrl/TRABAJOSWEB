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
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    public string? NombreReal { get; set; }

    [StringLength(50)]
    public string? Universo { get; set; }

    public int? SuperPoderId { get; set; }

    [ForeignKey("SuperPoderId")]
    [InverseProperty("Heroes")]
    public virtual SuperPoderes? SuperPoder { get; set; }
}

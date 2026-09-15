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
    public string Nombre { get; set; } = null!;

    [StringLength(500)]
    public string? Descripcion { get; set; }

    [InverseProperty("SuperPoder")]
    public virtual ICollection<Heroes> Heroes { get; set; } = new List<Heroes>();
}

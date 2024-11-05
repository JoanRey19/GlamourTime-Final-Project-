using System;
using System.Collections.Generic;

namespace GlamourTime.web.Models;

public partial class Stylist
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Specialty { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}

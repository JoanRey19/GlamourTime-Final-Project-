using System;
using System.Collections.Generic;

namespace GlamourTime.web.Models;

public partial class Appointment
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int StylistId { get; set; }

    public int ServiceId { get; set; }

    public DateTime DateTime { get; set; }

    public bool Confirmed { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;

    public virtual Stylist Stylist { get; set; } = null!;
}

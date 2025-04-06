using System;
using System.Collections.Generic;

namespace ST10281928_NDIVHUWO_NDOU_EventEase_CLDV6211.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string EventName { get; set; } = null!;

    public DateOnly EventDate { get; set; }

    public string EventDescription { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}

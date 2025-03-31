using System;
using System.Collections.Generic;

namespace ST10281928_NDIVHUWO_NDOU_CLDV6211_EventEase.Models;

public partial class Event
{
    public int EventId { get; set; }

    public string EventName { get; set; } = null!;

    public string EventDate { get; set; } = null!;

    public string EventDescription { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}

using System;
using System.Collections.Generic;

namespace ST10281928_NDIVHUWO_NDOU_EventEase_CLDV6211.Models;

public partial class Venue
{
    public int VenueId { get; set; }

    public string VenueName { get; set; } = null!;

    public string VenueLocation { get; set; } = null!;

    public int VenueCapacity { get; set; }

    public string ImageUrl { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}

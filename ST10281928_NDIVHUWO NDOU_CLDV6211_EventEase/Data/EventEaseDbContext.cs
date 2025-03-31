using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ST10281928_NDIVHUWO_NDOU_CLDV6211_EventEase.Models;

namespace ST10281928_NDIVHUWO_NDOU_CLDV6211_EventEase.Data;

public partial class EventEaseDbContext : DbContext
{
    public EventEaseDbContext()
    {
    }

    public EventEaseDbContext(DbContextOptions<EventEaseDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Venue> Venues { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Booking__73951ACDB0C0F073");

            entity.ToTable("Booking");

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.BookingDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.VenueId).HasColumnName("VenueID");

            entity.HasOne(d => d.Event).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.EventId)
                .HasConstraintName("FK__Booking__EventID__3C69FB99");

            entity.HasOne(d => d.Venue).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.VenueId)
                .HasConstraintName("FK__Booking__VenueID__3B75D760");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Event__7944C87034AD3B13");

            entity.ToTable("Event");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EventDescription).IsUnicode(false);
            entity.Property(e => e.EventName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Venue>(entity =>
        {
            entity.HasKey(e => e.VenueId).HasName("PK__Venue__3C57E5D28E5890F6");

            entity.ToTable("Venue");

            entity.Property(e => e.VenueId).HasColumnName("VenueID");
            entity.Property(e => e.ImageUrl)
                .IsUnicode(false)
                .HasColumnName("ImageURL");
            entity.Property(e => e.VenueLocation)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.VenueName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

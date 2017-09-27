using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SqlPingWeb.Models
{
    public class PingContext : DbContext
    {
        public PingContext(DbContextOptions<PingContext> options) : base(options)
        {
        }

        public DbSet<Ping> Pings { get; set; }
    }

    public class Ping
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
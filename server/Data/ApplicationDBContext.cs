using System;
using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data;

public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : DbContext(options)
{
    public DbSet<Stock>? Stocks { get; set; }

    public DbSet<Comment>? Comments { get; set; }
}

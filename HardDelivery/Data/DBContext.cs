using HardDelivery.Models;
using Microsoft.EntityFrameworkCore;

namespace HardDelivery.Data
{
	public class DBContext : DbContext
	{
		public DBContext() { }
		public DBContext(DbContextOptions<DBContext> options) : base(options)
		{

		}
		DbSet<Address> addresses { get; set; }
		DbSet<Delivery> deliveries { get; set; }
		DbSet<User> users { get; set; }
		DbSet<Payment> invoices { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(Configuration.ConnectionString);
			}
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}

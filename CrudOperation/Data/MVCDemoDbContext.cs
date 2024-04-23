using System;
using CrudOperation.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Data
{
	public class MVCDemoDbContext : DbContext 
	{
		public MVCDemoDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Employee> Employees { get; set; }
	}
}


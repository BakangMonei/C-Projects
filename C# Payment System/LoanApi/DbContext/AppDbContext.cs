using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApi.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Sequence> Sequence { get; set; }
        public DbSet<Alert> Alert { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Cot> Cot { get; set; }
        public DbSet<Charge> Charge { get; set; }
        public DbSet<Cheque> Cheque { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Garantor> Garantor { get; set; }
        public DbSet<SmsApi> SmsApi { get; set; }
        public DbSet<Sms> Sms { get; set; }
        public DbSet<SmsBoardcast> SmsBoardcast { get; set; }
        public DbSet<MainNominal> MainNominal { get; set; }
        public DbSet<Nominal> Nominal { get; set; }
        public DbSet<Teller> Teller { get; set; }
        public DbSet<Transit> Transit { get; set; }
        public DbSet<Transaction> Transaction { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }
    }
}
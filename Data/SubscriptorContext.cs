using Microsoft.EntityFrameworkCore;
using Subscriptor.Models;

namespace Subscriptor.Data 
{
    public class SubscriptorContext : DbContext 
    {
        public SubscriptorContext (DbContextOptions<SubscriptorContext> options) : base(options) {}

        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<BillingPlan> BillingPlans { get; set; }
    }
}
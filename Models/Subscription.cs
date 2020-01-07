
namespace Subscriptor.Models
{
    public class Subscription {
        public int Id { get; set; }
        public BillingPlan BillingPlan { get; set; }
        public decimal Rate { get; set; }    
    }
}
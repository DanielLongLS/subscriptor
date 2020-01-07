using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Subscriptor.Models 
{
    [Table("billing_plans")]
    public class BillingPlan 
    {
        public int Id { get; set; }
        public int dayToBill { get; set; }
    }
}
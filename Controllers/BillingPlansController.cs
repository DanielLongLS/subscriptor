using Microsoft.AspNetCore.Mvc;
using Subscriptor.Data;
using Subscriptor.Models;

namespace Subscriptor.Controllers 
{
    [ApiController]
    [Route("api/billing_plans")]
    public class BillingPlansController : Controller 
    {
        private readonly SubscriptorContext _context;

        public BillingPlansController(SubscriptorContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<Subscription> index() 
        {
            return Ok(_context.BillingPlans);
        }

        [HttpGet("{id}")]
        public ActionResult<Subscription> show(int id)
        {
            return Ok(_context.BillingPlans.Find(1));
        }
    }
}
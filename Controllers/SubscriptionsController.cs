using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Subscriptor.Data;
using Subscriptor.Models;

namespace Subscriptor.Controllers 
{
    [ApiController]
    [Route("api/subscriptions")]
    public class SubscriptionsController : Controller 
    {
        private readonly SubscriptorContext _context;

        public SubscriptionsController(SubscriptorContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<Subscription> index() 
        {
            return Ok(_context.Subscriptions.Include(sub => sub.BillingPlan));
        }

        [HttpGet("{id}")]
        public ActionResult<Subscription> show(int id)
        {
            return Ok(_context.Subscriptions.Find(id));
        }
    }
}
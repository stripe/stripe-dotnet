using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripe.Services
{
    public class BaseStripeService : IStripeService
    {
        public BaseStripeService(string apiKey = null)
        {
            ApiKey = apiKey;
        }
        public string ApiKey { get; set; }
    }
}

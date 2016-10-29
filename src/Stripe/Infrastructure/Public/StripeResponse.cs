using System;

namespace Stripe
{
    public class StripeResponse
    {
        public string ResponseJson { get; set; }
        public string ObjectJson { get; set; }
        public string RequestId { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
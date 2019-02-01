namespace Stripe
{
    using System;

    public class StripeResponse
    {
        public string ResponseJson { get; set; }

        public string RequestId { get; set; }

        public DateTime RequestDate { get; set; }
    }
}

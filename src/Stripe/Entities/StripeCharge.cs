using System;

namespace Stripe
{
    public class StripeCharge
    {
        [StripeArgument("id")]
        public string Id { get; set; }

        [StripeArgument("amount")]
        public int? AmountInCents { get; set; }

        [StripeArgument("amount_refunded")]
        public int? AmountInCentsRefunded { get; set; }

        [StripeArgument("created")]
        public DateTime Created { get; set; }

        [StripeArgument("currency")]
        public string Currency { get; set; }

        [StripeArgument("customer")]
        public string CustomerId { get; set; }

        [StripeArgument("description")]
        public string Description { get; set; }

        [StripeArgument("fee")]
        public int? FeeInCents { get; set; }

        [StripeArgument("paid")]
        public bool? Paid { get; set; }

        [StripeArgument("refunded")]
        public bool? Refunded { get; set; }

        [StripeArgument("livemode")]
        public bool? LiveMode { get; set; }

        public StripeCard StripeCard { get; set; }
    }
}
using System;

namespace Stripe
{
    public class StripeToken
    {
        [StripeArgument("id")]
        public string Id { get; set; }

        [StripeArgument("amount")]
        public int? AmountInCents { get; set; }

        [StripeArgument("created")]
        public DateTime? Created { get; set; }

        [StripeArgument("currency")]
        public string Currency { get; set; }

        [StripeArgument("description")]
        public string Description { get; set; }

        [StripeArgument("used")]
        public bool? Used { get; set; }

        [StripeArgument("livemode")]
        public bool? LiveMode { get; set; }

        public StripeCard StripeCard { get; set; }
    }
}
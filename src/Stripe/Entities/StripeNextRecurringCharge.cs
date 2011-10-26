using System;

namespace Stripe
{
    public class StripeNextRecurringCharge
    {
        [StripeArgument("amount")]
        public string AmountInCents { get; set; }

        [StripeArgument("date")]
        public DateTime? Date { get; set; }
    }
}

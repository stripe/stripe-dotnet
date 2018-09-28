namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class OrderStatusTransitionsOptions : INestedOptions
    {
        [FormProperty("canceled")]
        public DateFilter Canceled { get; set; }

        [FormProperty("fulfilled")]
        public DateFilter Fulfilled { get; set; }

        [FormProperty("paid")]
        public DateFilter Paid { get; set; }

        [FormProperty("returned")]
        public DateFilter Returned { get; set; }
    }
}

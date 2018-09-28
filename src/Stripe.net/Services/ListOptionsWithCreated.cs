namespace Stripe
{
    using System;
    using Stripe.Infrastructure;

    public class ListOptionsWithCreated : ListOptions
    {
        [FormProperty("created")]
        public DateTime? Created { get; set; }

        [FormProperty("created")]
        internal string CreatedInternal => this.Created?.ConvertDateTimeToEpoch().ToString();

        [FormProperty("created[gt]")]
        public DateTime? GreaterThan { get; set; }

        [FormProperty("created[gte]")]
        public DateTime? GreaterThanOrEqual { get; set; }

        [FormProperty("created[lt]")]
        public DateTime? LessThan { get; set; }

        [FormProperty("created[lte]")]
        public DateTime? LessThanOrEqual { get; set; }
    }
}

namespace Stripe
{
    using System;
    using Stripe.Infrastructure;

    public class DateFilter
    {
        [FormProperty("")]
        public DateTime? EqualTo { get; set; }

        [FormProperty("[gt]")]
        public DateTime? GreaterThan { get; set; }

        [FormProperty("[gte]")]
        public DateTime? GreaterThanOrEqual { get; set; }

        [FormProperty("[lt]")]
        public DateTime? LessThan { get; set; }

        [FormProperty("[lte]")]
        public DateTime? LessThanOrEqual { get; set; }
    }
}

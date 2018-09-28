namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class InvoicePayOptions : BaseOptions
    {
        [FormProperty("forgive")]
        public bool? Forgive { get; set; }

        [FormProperty("source")]
        public string SourceId { get; set; }
    }
}

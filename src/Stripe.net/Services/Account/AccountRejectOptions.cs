namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class AccountRejectOptions : BaseOptions
    {
        [FormProperty("reason")]
        public string Reason { get; set; }
    }
}

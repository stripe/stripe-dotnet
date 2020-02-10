namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceAlipay : StripeEntity<SourceAlipay>
    {
        // The Alipay sources do not have any specific property today.
        // The only ones available in the spec are used for mobile SDKs.
    }
}

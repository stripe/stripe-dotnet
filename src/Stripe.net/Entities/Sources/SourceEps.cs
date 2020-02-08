namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceEps : StripeEntity<SourceEps>
    {
        // The Eps sources do not have any specific property today.
        // The only ones available in the spec are for private betas.
    }
}

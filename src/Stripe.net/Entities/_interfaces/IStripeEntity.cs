namespace Stripe
{
    using System.Collections.Generic;

    public interface IStripeEntity
    {
        StripeResponse StripeResponse { get; set; }
    }
}

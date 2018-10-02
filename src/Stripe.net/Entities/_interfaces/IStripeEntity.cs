namespace Stripe
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface that identifies all entities returned by Stripe.
    /// </summary>
    public interface IStripeEntity
    {
        StripeResponse StripeResponse { get; set; }
    }
}

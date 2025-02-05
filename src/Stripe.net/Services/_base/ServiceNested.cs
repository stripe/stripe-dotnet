namespace Stripe
{
    using System;

    [Obsolete("This class is deprecated and will be removed in a future release.  Use StripeClient#RequestAsync or StripeClient#RawRequest instead.")]
    public abstract class ServiceNested<TEntityReturned> : Service<TEntityReturned>
        where TEntityReturned : IStripeEntity
    {
        protected ServiceNested()
            : base()
        {
        }

        internal ServiceNested(ApiRequestor requestor)
            : base(requestor)
        {
        }

        protected ServiceNested(IStripeClient client)
            : base(client)
        {
        }
    }
}

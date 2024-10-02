namespace Stripe
{
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

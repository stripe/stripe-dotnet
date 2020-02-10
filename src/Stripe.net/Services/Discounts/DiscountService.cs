namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class DiscountService : Service<Discount>
    {
        public DiscountService()
            : base(null)
        {
        }

        public DiscountService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => null;

        public virtual Discount DeleteCustomerDiscount(string id, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Delete, $"/v1/customers/{id}/discount", null, requestOptions);
        }

        public virtual Task<Discount> DeleteCustomerDiscountAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Delete, $"/v1/customers/{id}/discount", null, requestOptions, cancellationToken);
        }

        public virtual Discount DeleteSubscriptionDiscount(string id, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Delete, $"/v1/subscriptions/{id}/discount", null, requestOptions);
        }

        public virtual Task<Discount> DeleteSubscriptionDiscountAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Delete, $"/v1/subscriptions/{id}/discount", null, requestOptions, cancellationToken);
        }
    }
}

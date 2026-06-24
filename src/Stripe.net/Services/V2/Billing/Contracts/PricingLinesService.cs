// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Contracts
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class PricingLinesService : Service
    {
        private V2.Billing.Contracts.PricingLines.QuantityChangeService quantityChanges;

        internal PricingLinesService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PricingLinesService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.Contracts.PricingLines.QuantityChangeService QuantityChanges => this.quantityChanges ??= new V2.Billing.Contracts.PricingLines.QuantityChangeService(
            this.Requestor);
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Billing.Contracts
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class LicensePricingService : Service
    {
        private V2.Billing.Contracts.LicensePricing.QuantityChangeService quantityChanges;

        internal LicensePricingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal LicensePricingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.Contracts.LicensePricing.QuantityChangeService QuantityChanges => this.quantityChanges ??= new V2.Billing.Contracts.LicensePricing.QuantityChangeService(
            this.Requestor);
    }
}

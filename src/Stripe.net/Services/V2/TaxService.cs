// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxService : Service
    {
        private V2.Tax.ManualRuleService manualRules;

        internal TaxService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TaxService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Tax.ManualRuleService ManualRules => this.manualRules ??= new V2.Tax.ManualRuleService(
            this.Requestor);
    }
}

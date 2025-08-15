// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxService : Service
    {
        private V2.Tax.AutomaticRuleService automaticRules;

        internal TaxService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TaxService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Tax.AutomaticRuleService AutomaticRules => this.automaticRules ??= new V2.Tax.AutomaticRuleService(
            this.Requestor);
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class TaxService : Service
    {
        private V2.Tax.IntegrationConfigurationService integrationConfigurations;
        private V2.Tax.ManualRuleService manualRules;
        private V2.Tax.OperationService operations;

        internal TaxService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal TaxService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Tax.IntegrationConfigurationService IntegrationConfigurations => this.integrationConfigurations ??= new V2.Tax.IntegrationConfigurationService(
            this.Requestor);

        public virtual V2.Tax.ManualRuleService ManualRules => this.manualRules ??= new V2.Tax.ManualRuleService(
            this.Requestor);

        public virtual V2.Tax.OperationService Operations => this.operations ??= new V2.Tax.OperationService(
            this.Requestor);
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class MoneyManagementService : Service
    {
        private V2.MoneyManagement.OutboundSetupIntentService outboundSetupIntents;
        private V2.MoneyManagement.PayoutMethodService payoutMethods;
        private V2.MoneyManagement.PayoutMethodsBankAccountSpecService payoutMethodsBankAccountSpec;

        internal MoneyManagementService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal MoneyManagementService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.MoneyManagement.OutboundSetupIntentService OutboundSetupIntents => this.outboundSetupIntents ??= new V2.MoneyManagement.OutboundSetupIntentService(
            this.Requestor);

        public virtual V2.MoneyManagement.PayoutMethodService PayoutMethods => this.payoutMethods ??= new V2.MoneyManagement.PayoutMethodService(
            this.Requestor);

        public virtual V2.MoneyManagement.PayoutMethodsBankAccountSpecService PayoutMethodsBankAccountSpec => this.payoutMethodsBankAccountSpec ??= new V2.MoneyManagement.PayoutMethodsBankAccountSpecService(
            this.Requestor);
    }
}

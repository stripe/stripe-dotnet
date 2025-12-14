// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentService : Service
    {
        private V2.Payments.OffSessionPaymentService offSessionPayments;
        private V2.Payments.SettlementAllocationIntentService settlementAllocationIntents;

        internal PaymentService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PaymentService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Payments.OffSessionPaymentService OffSessionPayments => this.offSessionPayments ??= new V2.Payments.OffSessionPaymentService(
            this.Requestor);

        public virtual V2.Payments.SettlementAllocationIntentService SettlementAllocationIntents => this.settlementAllocationIntents ??= new V2.Payments.SettlementAllocationIntentService(
            this.Requestor);
    }
}

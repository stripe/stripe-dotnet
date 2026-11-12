// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class PaymentsService : Service
    {
        private V2.Payments.OffSessionPaymentService offSessionPayments;

        internal PaymentsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PaymentsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Payments.OffSessionPaymentService OffSessionPayments => this.offSessionPayments ??= new V2.Payments.OffSessionPaymentService(
            this.Requestor);
    }
}

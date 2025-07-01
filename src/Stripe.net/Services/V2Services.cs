// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class V2Services : Service
    {
        private V2.BillingService billing;
        private V2.CoreService core;
        private V2.MoneyManagementService moneyManagement;
        private V2.PaymentService payments;
        private V2.TestHelperService testHelpers;

        internal V2Services(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal V2Services(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.BillingService Billing => this.billing ??= new V2.BillingService(
            this.Requestor);

        public virtual V2.CoreService Core => this.core ??= new V2.CoreService(
            this.Requestor);

        public virtual V2.MoneyManagementService MoneyManagement => this.moneyManagement ??= new V2.MoneyManagementService(
            this.Requestor);

        public virtual V2.PaymentService Payments => this.payments ??= new V2.PaymentService(
            this.Requestor);

        public virtual V2.TestHelperService TestHelpers => this.testHelpers ??= new V2.TestHelperService(
            this.Requestor);
    }
}

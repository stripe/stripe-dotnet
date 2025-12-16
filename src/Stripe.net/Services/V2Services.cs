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
        private V2.IamService iam;
        private V2.MoneyManagementService moneyManagement;
        private V2.PaymentService payments;
        private V2.ReportingService reporting;
        private V2.TaxService tax;
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

        public virtual V2.IamService Iam => this.iam ??= new V2.IamService(
            this.Requestor);

        public virtual V2.MoneyManagementService MoneyManagement => this.moneyManagement ??= new V2.MoneyManagementService(
            this.Requestor);

        public virtual V2.PaymentService Payments => this.payments ??= new V2.PaymentService(
            this.Requestor);

        public virtual V2.ReportingService Reporting => this.reporting ??= new V2.ReportingService(
            this.Requestor);

        public virtual V2.TaxService Tax => this.tax ??= new V2.TaxService(
            this.Requestor);

        public virtual V2.TestHelperService TestHelpers => this.testHelpers ??= new V2.TestHelperService(
            this.Requestor);
    }
}

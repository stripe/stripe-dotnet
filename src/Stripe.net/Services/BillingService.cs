// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class BillingService : Service
    {
        private Billing.AlertService alerts;
        private Billing.CreditBalanceSummaryService creditBalanceSummary;
        private Billing.CreditBalanceTransactionService creditBalanceTransactions;
        private Billing.CreditGrantService creditGrants;
        private Billing.MeterService meters;
        private Billing.MeterEventService meterEvents;
        private Billing.MeterEventAdjustmentService meterEventAdjustments;

        internal BillingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal BillingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Billing.AlertService Alerts => this.alerts ??= new Billing.AlertService(
            this.Requestor);

        public virtual Billing.CreditBalanceSummaryService CreditBalanceSummary => this.creditBalanceSummary ??= new Billing.CreditBalanceSummaryService(
            this.Requestor);

        public virtual Billing.CreditBalanceTransactionService CreditBalanceTransactions => this.creditBalanceTransactions ??= new Billing.CreditBalanceTransactionService(
            this.Requestor);

        public virtual Billing.CreditGrantService CreditGrants => this.creditGrants ??= new Billing.CreditGrantService(
            this.Requestor);

        public virtual Billing.MeterService Meters => this.meters ??= new Billing.MeterService(
            this.Requestor);

        public virtual Billing.MeterEventService MeterEvents => this.meterEvents ??= new Billing.MeterEventService(
            this.Requestor);

        public virtual Billing.MeterEventAdjustmentService MeterEventAdjustments => this.meterEventAdjustments ??= new Billing.MeterEventAdjustmentService(
            this.Requestor);
    }
}

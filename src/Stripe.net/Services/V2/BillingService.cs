// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class BillingService : Service
    {
        private V2.Billing.BillSettingService billSettings;
        private V2.Billing.CadenceService cadences;
        private V2.Billing.CollectionSettingService collectionSettings;
        private V2.Billing.MeterEventService meterEvents;
        private V2.Billing.MeterEventAdjustmentService meterEventAdjustments;
        private V2.Billing.MeterEventSessionService meterEventSession;
        private V2.Billing.MeterEventStreamService meterEventStream;
        private V2.Billing.ProfileService profiles;

        internal BillingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal BillingService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Billing.BillSettingService BillSettings => this.billSettings ??= new V2.Billing.BillSettingService(
            this.Requestor);

        public virtual V2.Billing.CadenceService Cadences => this.cadences ??= new V2.Billing.CadenceService(
            this.Requestor);

        public virtual V2.Billing.CollectionSettingService CollectionSettings => this.collectionSettings ??= new V2.Billing.CollectionSettingService(
            this.Requestor);

        public virtual V2.Billing.MeterEventService MeterEvents => this.meterEvents ??= new V2.Billing.MeterEventService(
            this.Requestor);

        public virtual V2.Billing.MeterEventAdjustmentService MeterEventAdjustments => this.meterEventAdjustments ??= new V2.Billing.MeterEventAdjustmentService(
            this.Requestor);

        public virtual V2.Billing.MeterEventSessionService MeterEventSession => this.meterEventSession ??= new V2.Billing.MeterEventSessionService(
            this.Requestor);

        public virtual V2.Billing.MeterEventStreamService MeterEventStream => this.meterEventStream ??= new V2.Billing.MeterEventStreamService(
            this.Requestor);

        public virtual V2.Billing.ProfileService Profiles => this.profiles ??= new V2.Billing.ProfileService(
            this.Requestor);
    }
}

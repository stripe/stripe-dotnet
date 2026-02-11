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
        private V2.Billing.CustomPricingUnitService customPricingUnits;
        private V2.Billing.IntentService intents;
        private V2.Billing.LicenseFeeService licenseFees;
        private V2.Billing.LicenseFeeSubscriptionService licenseFeeSubscriptions;
        private V2.Billing.LicensedItemService licensedItems;
        private V2.Billing.MeterEventService meterEvents;
        private V2.Billing.MeterEventAdjustmentService meterEventAdjustments;
        private V2.Billing.MeterEventSessionService meterEventSession;
        private V2.Billing.MeterEventStreamService meterEventStream;
        private V2.Billing.MeteredItemService meteredItems;
        private V2.Billing.OneTimeItemService oneTimeItems;
        private V2.Billing.PricingPlanService pricingPlans;
        private V2.Billing.PricingPlanSubscriptionService pricingPlanSubscriptions;
        private V2.Billing.ProfileService profiles;
        private V2.Billing.RateCardService rateCards;
        private V2.Billing.RateCardSubscriptionService rateCardSubscriptions;
        private V2.Billing.ServiceActionService serviceActions;

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

        public virtual V2.Billing.CustomPricingUnitService CustomPricingUnits => this.customPricingUnits ??= new V2.Billing.CustomPricingUnitService(
            this.Requestor);

        public virtual V2.Billing.IntentService Intents => this.intents ??= new V2.Billing.IntentService(
            this.Requestor);

        public virtual V2.Billing.LicenseFeeService LicenseFees => this.licenseFees ??= new V2.Billing.LicenseFeeService(
            this.Requestor);

        public virtual V2.Billing.LicenseFeeSubscriptionService LicenseFeeSubscriptions => this.licenseFeeSubscriptions ??= new V2.Billing.LicenseFeeSubscriptionService(
            this.Requestor);

        public virtual V2.Billing.LicensedItemService LicensedItems => this.licensedItems ??= new V2.Billing.LicensedItemService(
            this.Requestor);

        public virtual V2.Billing.MeterEventService MeterEvents => this.meterEvents ??= new V2.Billing.MeterEventService(
            this.Requestor);

        public virtual V2.Billing.MeterEventAdjustmentService MeterEventAdjustments => this.meterEventAdjustments ??= new V2.Billing.MeterEventAdjustmentService(
            this.Requestor);

        public virtual V2.Billing.MeterEventSessionService MeterEventSession => this.meterEventSession ??= new V2.Billing.MeterEventSessionService(
            this.Requestor);

        public virtual V2.Billing.MeterEventStreamService MeterEventStream => this.meterEventStream ??= new V2.Billing.MeterEventStreamService(
            this.Requestor);

        public virtual V2.Billing.MeteredItemService MeteredItems => this.meteredItems ??= new V2.Billing.MeteredItemService(
            this.Requestor);

        public virtual V2.Billing.OneTimeItemService OneTimeItems => this.oneTimeItems ??= new V2.Billing.OneTimeItemService(
            this.Requestor);

        public virtual V2.Billing.PricingPlanService PricingPlans => this.pricingPlans ??= new V2.Billing.PricingPlanService(
            this.Requestor);

        public virtual V2.Billing.PricingPlanSubscriptionService PricingPlanSubscriptions => this.pricingPlanSubscriptions ??= new V2.Billing.PricingPlanSubscriptionService(
            this.Requestor);

        public virtual V2.Billing.ProfileService Profiles => this.profiles ??= new V2.Billing.ProfileService(
            this.Requestor);

        public virtual V2.Billing.RateCardService RateCards => this.rateCards ??= new V2.Billing.RateCardService(
            this.Requestor);

        public virtual V2.Billing.RateCardSubscriptionService RateCardSubscriptions => this.rateCardSubscriptions ??= new V2.Billing.RateCardSubscriptionService(
            this.Requestor);

        public virtual V2.Billing.ServiceActionService ServiceActions => this.serviceActions ??= new V2.Billing.ServiceActionService(
            this.Requestor);
    }
}

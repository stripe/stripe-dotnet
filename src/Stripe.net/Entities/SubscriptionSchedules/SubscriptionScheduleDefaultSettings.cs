namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleDefaultSettings : StripeEntity<SubscriptionScheduleDefaultSettings>
    {
        [JsonProperty("billing_cycle_anchor")]
        public string BillingCycleAnchor { get; set; }

        [JsonProperty("billing_thresholds")]
        public SubscriptionScheduleDefaultSettingsBillingThresholds BillingThresholds { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        #region Expandable DefaultPaymentMethod

        [JsonIgnore]
        public string DefaultPaymentMethodId
        {
            get => this.InternalDefaultPaymentMethod?.Id;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldId(value, this.InternalDefaultPaymentMethod);
        }

        [JsonIgnore]
        public PaymentMethod DefaultPaymentMethod
        {
            get => this.InternalDefaultPaymentMethod?.ExpandedObject;
            set => this.InternalDefaultPaymentMethod = SetExpandableFieldObject(value, this.InternalDefaultPaymentMethod);
        }

        [JsonProperty("default_payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalDefaultPaymentMethod { get; set; }
        #endregion

        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleDefaultSettingsInvoiceSettings InvoiceSettings { get; set; }

        [JsonProperty("transfer_data")]
        public SubscriptionScheduleDefaultSettingsTransferData TransferData { get; set; }
    }
}

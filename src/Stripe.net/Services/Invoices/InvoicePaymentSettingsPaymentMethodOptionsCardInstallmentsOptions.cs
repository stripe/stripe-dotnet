// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsOptions : INestedOptions, IHasSetTracking
    {
        private InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlanOptions plan;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Setting to true enables installments for this invoice. Setting to false will prevent any
        /// selected plan from applying to a payment.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The selected installment plan to use for this invoice.
        /// </summary>
        [JsonProperty("plan")]
        [STJS.JsonPropertyName("plan")]
        public InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlanOptions Plan
        {
            get => this.plan;
            set
            {
                this.plan = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

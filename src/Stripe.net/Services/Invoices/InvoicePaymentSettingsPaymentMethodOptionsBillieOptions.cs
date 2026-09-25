// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsBillieOptions : INestedOptions, IHasSetTracking
    {
        private InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOptions companyDetails;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Registration details about the buyer's organization.
        /// </summary>
        [JsonProperty("company_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("company_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public InvoicePaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOptions CompanyDetails
        {
            get => this.companyDetails;
            set
            {
                this.companyDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// An identifier or reference that this payment corresponds to.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

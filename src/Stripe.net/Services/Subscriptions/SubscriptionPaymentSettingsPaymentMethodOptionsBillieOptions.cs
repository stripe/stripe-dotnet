// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBillieOptions : INestedOptions, IHasSetTracking
    {
        private SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOptions companyDetails;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Registration details about the buyer's organization.
        /// </summary>
        [JsonProperty("company_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("company_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetailsOptions CompanyDetails
        {
            get => this.companyDetails;
            set
            {
                this.companyDetails = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}

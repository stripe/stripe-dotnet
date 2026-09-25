// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBillie : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsBillie>
    {
        [JsonProperty("company_details")]
        [STJS.JsonPropertyName("company_details")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBillieCompanyDetails CompanyDetails { get; set; }
    }
}

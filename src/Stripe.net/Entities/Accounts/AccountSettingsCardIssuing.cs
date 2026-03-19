// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsCardIssuing : StripeEntity<AccountSettingsCardIssuing>
    {
        [JsonProperty("tos_acceptance")]
        [STJS.JsonPropertyName("tos_acceptance")]
        public AccountSettingsCardIssuingTosAcceptance TosAcceptance { get; set; }
    }
}

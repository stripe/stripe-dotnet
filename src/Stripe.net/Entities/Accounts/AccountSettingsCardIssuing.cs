// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSettingsCardIssuing : StripeEntity<AccountSettingsCardIssuing>
    {
        [JsonProperty("tos_acceptance")]
        public AccountSettingsCardIssuingTosAcceptance TosAcceptance { get; set; }
    }
}

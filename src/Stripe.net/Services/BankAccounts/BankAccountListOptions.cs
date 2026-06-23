namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BankAccountListOptions : ListOptions
    {
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        internal string Object => "bank_account";
    }
}

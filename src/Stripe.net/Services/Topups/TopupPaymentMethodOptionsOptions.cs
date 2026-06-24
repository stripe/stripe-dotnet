// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TopupPaymentMethodOptionsOptions : INestedOptions
    {
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public TopupPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}

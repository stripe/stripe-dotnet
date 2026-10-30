// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAddressCreateBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The country where Stripe provisions the bank account. Each currency supports the country
        /// listed in its description. If omitted, Stripe selects that country.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The currency of the bank account to provision. Some currencies require preview or
        /// rollout access, as configured for your account.
        /// One of: <c>brl</c>, <c>cad</c>, <c>cop</c>, <c>eur</c>, <c>gbp</c>, <c>mxn</c>,
        /// <c>ngn</c>, <c>pln</c>, or <c>usd</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}

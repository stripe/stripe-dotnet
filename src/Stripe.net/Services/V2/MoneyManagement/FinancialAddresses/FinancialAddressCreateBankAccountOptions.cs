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
        /// The country for the bank account. Used to select the appropriate rails (e.g. for SEPA).
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The currency of the bank account to provision.
        /// One of: <c>cad</c>, <c>eur</c>, <c>gbp</c>, <c>mxn</c>, or <c>usd</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}

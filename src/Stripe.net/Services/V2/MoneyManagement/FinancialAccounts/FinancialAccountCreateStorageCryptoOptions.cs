// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FinancialAccountCreateStorageCryptoOptions : INestedOptions
    {
        /// <summary>
        /// The blockchain network configured for each crypto currency. Keys are lowercase currency
        /// codes and must identify crypto currencies also present in <c>holds_currencies</c>.
        /// One of: <c>tempo</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("currency_networks")]
        [STJS.JsonPropertyName("currency_networks")]
        public Dictionary<string, string> CurrencyNetworks { get; set; }

        /// <summary>
        /// Describes who controls the private keys for the crypto storage.
        /// One of: <c>self</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("custody_model")]
        [STJS.JsonPropertyName("custody_model")]
        public string CustodyModel { get; set; }
    }
}

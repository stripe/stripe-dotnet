// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PlatformTaxFee : StripeEntity<PlatformTaxFee>, IHasId, IHasObject, IBalanceTransactionSource
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The Connected account that incurred this charge.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// The payment object that caused this tax to be inflicted.
        /// </summary>
        [JsonProperty("source_transaction")]
        public string SourceTransaction { get; set; }

        /// <summary>
        /// The type of tax (VAT).
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

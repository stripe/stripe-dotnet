// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationMerchantData : StripeEntity<AuthorizationMerchantData>
    {
        /// <summary>
        /// A categorization of the seller's type of business. See our <a
        /// href="https://docs.stripe.com/issuing/merchant-categories">merchant categories guide</a>
        /// for a list of possible values.
        /// </summary>
        [JsonProperty("category")]
        [STJS.JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// The merchant category code for the seller’s business.
        /// </summary>
        [JsonProperty("category_code")]
        [STJS.JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// City where the seller is located.
        /// </summary>
        [JsonProperty("city")]
        [STJS.JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Country where the seller is located.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Name of the seller.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier assigned to the seller by the card network. Different card networks may
        /// assign different network_id fields to the same merchant.
        /// </summary>
        [JsonProperty("network_id")]
        [STJS.JsonPropertyName("network_id")]
        public string NetworkId { get; set; }

        /// <summary>
        /// The identifier of the payment facilitator (PayFac) that processed this authorization, as
        /// assigned by the card network. Null when the transaction was not processed through a
        /// PayFac.
        /// </summary>
        [JsonProperty("payment_facilitator_id")]
        [STJS.JsonPropertyName("payment_facilitator_id")]
        public string PaymentFacilitatorId { get; set; }

        /// <summary>
        /// Postal code where the seller is located.
        /// </summary>
        [JsonProperty("postal_code")]
        [STJS.JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State where the seller is located.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The identifier of the sub-merchant involved in this authorization, as assigned by the
        /// payment facilitator. Null when the transaction was not processed through a PayFac or
        /// when no sub-merchant ID was provided.
        /// </summary>
        [JsonProperty("sub_merchant_id")]
        [STJS.JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// The seller's tax identification number. Currently populated for French merchants only.
        /// </summary>
        [JsonProperty("tax_id")]
        [STJS.JsonPropertyName("tax_id")]
        public string TaxId { get; set; }

        /// <summary>
        /// An ID assigned by the seller to the location of the sale.
        /// </summary>
        [JsonProperty("terminal_id")]
        [STJS.JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// URL provided by the merchant on a 3DS request.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}

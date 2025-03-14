// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCollectedInformation : StripeEntity<SessionCollectedInformation>
    {
        /// <summary>
        /// Customer’s business name for this Checkout Session.
        /// </summary>
        [JsonProperty("business_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("business_name")]
#endif
        public string BusinessName { get; set; }

        /// <summary>
        /// Customer’s email for this Checkout Session.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public string Email { get; set; }

        /// <summary>
        /// Customer’s phone number for this Checkout Session.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public string Phone { get; set; }

        /// <summary>
        /// Shipping information for this Checkout Session.
        /// </summary>
        [JsonProperty("shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_details")]
#endif
        public SessionCollectedInformationShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Customer’s tax ids for this Checkout Session.
        /// </summary>
        [JsonProperty("tax_ids")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_ids")]
#endif
        public List<SessionCollectedInformationTaxId> TaxIds { get; set; }
    }
}

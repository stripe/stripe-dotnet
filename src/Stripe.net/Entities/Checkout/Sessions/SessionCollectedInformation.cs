// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionCollectedInformation : StripeEntity<SessionCollectedInformation>
    {
        /// <summary>
        /// Customer’s business name for this Checkout Session.
        /// </summary>
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Customer’s email for this Checkout Session.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Customer’s phone number for this Checkout Session.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Shipping information for this Checkout Session.
        /// </summary>
        [JsonProperty("shipping_details")]
        public SessionCollectedInformationShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Customer’s tax ids for this Checkout Session.
        /// </summary>
        [JsonProperty("tax_ids")]
        public List<SessionCollectedInformationTaxId> TaxIds { get; set; }
    }
}

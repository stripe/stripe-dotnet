// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Licensed Item represents a billable item whose pricing is based on license fees. You
    /// can use license fees to specify the pricing and create subscriptions to these items.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class LicensedItem : StripeEntity<LicensedItem>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Description that customers see in the invoice line item. Maximum length of 250
        /// characters.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// An internal key you can use to search for a particular licensed item. Maximum length of
        /// 200 characters.
        /// </summary>
        [JsonProperty("lookup_key")]
        [STJS.JsonPropertyName("lookup_key")]
        public string LookupKey { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Stripe Tax details.
        /// </summary>
        [JsonProperty("tax_details")]
        [STJS.JsonPropertyName("tax_details")]
        public LicensedItemTaxDetails TaxDetails { get; set; }

        /// <summary>
        /// The unit to use when displaying prices for this billable item in places like Checkout.
        /// For example, set this field to "seat" for Checkout to display "(price) per seat", or
        /// "environment" to display "(price) per environment". Maximum length of 100 characters.
        /// </summary>
        [JsonProperty("unit_label")]
        [STJS.JsonPropertyName("unit_label")]
        public string UnitLabel { get; set; }
    }
}

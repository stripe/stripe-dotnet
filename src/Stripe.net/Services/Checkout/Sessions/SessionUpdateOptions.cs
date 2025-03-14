// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Information about the customer collected within the Checkout Session.
        /// </summary>
        [JsonProperty("collected_information")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collected_information")]
#endif
        public SessionCollectedInformationOptions CollectedInformation { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing.
        ///
        /// When updating line items, you must retransmit the entire array of line items.
        ///
        /// To retain an existing line item, specify its <c>id</c>.
        ///
        /// To update an existing line item, specify its <c>id</c> along with the new values of the
        /// fields to update.
        ///
        /// To add a new line item, specify a <c>price</c> and <c>quantity</c>. We don't currently
        /// support recurring prices.
        ///
        /// To remove an existing line item, omit the line item's ID from the retransmitted array.
        ///
        /// To reorder a line item, specify it at the desired position in the retransmitted array.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public List<SessionLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The shipping rate options to apply to this Session. Up to a maximum of 5.
        /// </summary>
        [JsonProperty("shipping_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_options")]
#endif
        public List<SessionShippingOptionOptions> ShippingOptions { get; set; }
    }
}

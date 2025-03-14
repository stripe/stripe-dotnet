// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsAmendmentItemActionSetOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the
        /// <c>discounts</c> array on the subscription item that matches that price. Otherwise, the
        /// <c>items</c> array is cleared and a single new item is added with the supplied
        /// <c>discounts</c>.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<InvoiceScheduleDetailsAmendmentItemActionSetDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the
        /// <c>metadata</c> on the subscription item that matches that price. Otherwise, the
        /// <c>items</c> array is cleared and a single new item is added with the supplied
        /// <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }

        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the quantity
        /// on the subscription item that matches that price. Otherwise, the <c>items</c> array is
        /// cleared and a single new item is added with the supplied <c>quantity</c>.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the
        /// <c>tax_rates</c> array on the subscription item that matches that price. Otherwise, the
        /// <c>items</c> array is cleared and a single new item is added with the supplied
        /// <c>tax_rates</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the
        /// <c>trial</c> configuration on the subscription item that matches that price. Otherwise,
        /// the <c>items</c> array is cleared and a single new item is added with the supplied
        /// <c>trial</c>.
        /// </summary>
        [JsonProperty("trial")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial")]
#endif
        public InvoiceScheduleDetailsAmendmentItemActionSetTrialOptions Trial { get; set; }
    }
}

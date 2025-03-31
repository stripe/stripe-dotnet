// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PromotionCodeListOptions : ListOptions
    {
        /// <summary>
        /// Filter promotion codes by whether they are active.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

        /// <summary>
        /// Only return promotion codes that have this case-insensitive code.
        /// </summary>
        [JsonProperty("code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("code")]
#endif
        public string Code { get; set; }

        /// <summary>
        /// Only return promotion codes for this coupon.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// A filter on the list, based on the object <c>created</c> field. The value can be a
        /// string with an integer Unix timestamp, or it can be a dictionary with a number of
        /// different query options.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return promotion codes that are restricted to this customer.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Only return promotion codes that are restricted to this account.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }
    }
}

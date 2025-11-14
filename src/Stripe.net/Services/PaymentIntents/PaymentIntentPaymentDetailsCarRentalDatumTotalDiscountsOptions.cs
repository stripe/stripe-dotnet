// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatumTotalDiscountsOptions : INestedOptions
    {
        /// <summary>
        /// Corporate client discount code.
        /// </summary>
        [JsonProperty("corporate_client_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("corporate_client_code")]
#endif
        public string CorporateClientCode { get; set; }

        /// <summary>
        /// Coupon code applied to the rental.
        /// </summary>
        [JsonProperty("coupon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("coupon")]
#endif
        public string Coupon { get; set; }

        /// <summary>
        /// Maximum number of free miles or kilometers included.
        /// </summary>
        [JsonProperty("maximum_free_miles_or_kilometers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum_free_miles_or_kilometers")]
#endif
        public long? MaximumFreeMilesOrKilometers { get; set; }
    }
}

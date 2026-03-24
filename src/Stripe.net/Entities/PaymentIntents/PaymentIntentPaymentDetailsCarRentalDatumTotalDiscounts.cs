// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumTotalDiscounts : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumTotalDiscounts>
    {
        /// <summary>
        /// Corporate client discount code.
        /// </summary>
        [JsonProperty("corporate_client_code")]
        [STJS.JsonPropertyName("corporate_client_code")]
        public string CorporateClientCode { get; set; }

        /// <summary>
        /// Coupon code applied.
        /// </summary>
        [JsonProperty("coupon")]
        [STJS.JsonPropertyName("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// Maximum free miles or kilometers included.
        /// </summary>
        [JsonProperty("maximum_free_miles_or_kilometers")]
        [STJS.JsonPropertyName("maximum_free_miles_or_kilometers")]
        public long MaximumFreeMilesOrKilometers { get; set; }
    }
}

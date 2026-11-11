// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCardPresentReceiptCardholderMessage : StripeEntity<ChargePaymentMethodDetailsCardPresentReceiptCardholderMessage>
    {
        /// <summary>
        /// Where the message must be printed or displayed. An empty list means the message must not
        /// be shown.
        /// One of: <c>cardholder_receipt</c>, <c>merchant_receipt</c>, or <c>point_of_sale</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("destinations")]
        [STJS.JsonPropertyName("destinations")]
        public List<string> Destinations { get; set; }

        /// <summary>
        /// The message from the card issuer, such as the remaining balance.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundSetupIntentCreatePayoutMethodDataApplePayOptions : INestedOptions
    {
        /// <summary>
        /// The paymentData property of the Apple-provided PKPaymentToken (or ApplePayPaymentToken,
        /// for Apple Pay on the Web) as a UTF-8 encoded serialization of a JSON dictionary.
        /// </summary>
        [JsonProperty("pk_token")]
        [STJS.JsonPropertyName("pk_token")]
        public string PkToken { get; set; }

        /// <summary>
        /// The paymentMethod.displayName property of the Apple-provided PKPaymentToken (or
        /// ApplePayPaymentToken, for Apple Pay on the Web), e.g. "Visa 1234".
        /// </summary>
        [JsonProperty("pk_token_display_name")]
        [STJS.JsonPropertyName("pk_token_display_name")]
        public string PkTokenDisplayName { get; set; }
    }
}

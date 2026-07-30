// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalPaymentDelinquencyExposure : StripeEntity<AccountSignalPaymentDelinquencyExposure>
    {
        /// <summary>
        /// Additional details about the exposure assessment.
        /// </summary>
        [JsonProperty("additional_details")]
        [STJS.JsonPropertyName("additional_details")]
        public AccountSignalPaymentDelinquencyExposureAdditionalDetails AdditionalDetails { get; set; }

        /// <summary>
        /// The exposure amount if this account becomes delinquent.
        /// </summary>
        [JsonProperty("exposure_amount")]
        [STJS.JsonPropertyName("exposure_amount")]
        public AccountSignalPaymentDelinquencyExposureExposureAmount ExposureAmount { get; set; }
    }
}

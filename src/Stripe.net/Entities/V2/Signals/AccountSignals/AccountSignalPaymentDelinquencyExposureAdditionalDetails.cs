// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalPaymentDelinquencyExposureAdditionalDetails : StripeEntity<AccountSignalPaymentDelinquencyExposureAdditionalDetails>
    {
        /// <summary>
        /// Total payments still exposed to dispute or refund risk in the event of delinquency.
        /// </summary>
        [JsonProperty("gross_exposure_amount")]
        [STJS.JsonPropertyName("gross_exposure_amount")]
        public AccountSignalPaymentDelinquencyExposureAdditionalDetailsGrossExposureAmount GrossExposureAmount { get; set; }

        /// <summary>
        /// Percentage of Gross Exposure expected to be disputed or refunded and materialize as a
        /// loss in the event of delinquency.
        /// </summary>
        [JsonProperty("loss_given_default_in_percentages")]
        [STJS.JsonPropertyName("loss_given_default_in_percentages")]
        public long? LossGivenDefaultInPercentages { get; set; }

        /// <summary>
        /// Predicted window size in days until dispute is raised.
        /// </summary>
        [JsonProperty("predicted_dispute_window_in_days")]
        [STJS.JsonPropertyName("predicted_dispute_window_in_days")]
        public long? PredictedDisputeWindowInDays { get; set; }
    }
}

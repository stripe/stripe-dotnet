// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSignalUserMerchantFit : StripeEntity<AccountSignalUserMerchantFit>
    {
        /// <summary>
        /// Categorical assessment of the user-merchant fit.
        /// One of: <c>standard</c>, <c>strong</c>, <c>unknown</c>, or <c>very_strong</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("fit_level")]
        [STJS.JsonPropertyName("fit_level")]
        public string FitLevel { get; set; }

        /// <summary>
        /// The specific fit score for the user, between 0.00 and 100.00. Absent when fit_level is
        /// unknown.
        /// </summary>
        [JsonProperty("score")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("score")]
        public decimal? Score { get; set; }
    }
}

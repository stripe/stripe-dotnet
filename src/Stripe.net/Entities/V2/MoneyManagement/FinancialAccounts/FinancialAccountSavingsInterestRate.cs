// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountSavingsInterestRate : StripeEntity<FinancialAccountSavingsInterestRate>
    {
        /// <summary>
        /// Current variable rate, e.g. "3.00".
        /// </summary>
        [JsonProperty("percentage")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("percentage")]
        public decimal Percentage { get; set; }

        /// <summary>
        /// The period over which interest accrues.
        /// One of: <c>annual</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public string Period { get; set; }
    }
}

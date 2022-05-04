// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodDataIdealOptions : INestedOptions
    {
        /// <summary>
        /// The customer's bank.
        /// One of: <c>abn_amro</c>, <c>asn_bank</c>, <c>bunq</c>, <c>handelsbanken</c>, <c>ing</c>,
        /// <c>knab</c>, <c>moneyou</c>, <c>rabobank</c>, <c>regiobank</c>, <c>revolut</c>,
        /// <c>sns_bank</c>, <c>triodos_bank</c>, or <c>van_lanschot</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}

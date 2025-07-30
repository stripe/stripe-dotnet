// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputePaymentMethodDetailsCard : StripeEntity<DisputePaymentMethodDetailsCard>
    {
        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c> or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("brand")]
#endif
        public string Brand { get; set; }

        /// <summary>
        /// The type of dispute opened. Different case types may have varying fees and financial
        /// impact.
        /// One of: <c>chargeback</c>, <c>compliance</c>, or <c>inquiry</c>.
        /// </summary>
        [JsonProperty("case_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("case_type")]
#endif
        public string CaseType { get; set; }

        /// <summary>
        /// The card network's specific dispute reason code, which maps to one of Stripe's primary
        /// dispute categories to simplify response guidance. The <a
        /// href="https://stripe.com/docs/disputes/categories#network-code-map">Network code map</a>
        /// lists all available dispute reason codes by network.
        /// </summary>
        [JsonProperty("network_reason_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_reason_code")]
#endif
        public string NetworkReasonCode { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputePaymentMethodDetailsCard : StripeEntity<DisputePaymentMethodDetailsCard>
    {
        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>,
        /// <c>eftpos_au</c>, <c>jcb</c>, <c>link</c>, <c>mastercard</c>, <c>unionpay</c>,
        /// <c>visa</c> or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The type of dispute opened. Different case types may have varying fees and financial
        /// impact.
        /// One of: <c>block</c>, <c>chargeback</c>, <c>compliance</c>, <c>inquiry</c>, or
        /// <c>resolution</c>.
        /// </summary>
        [JsonProperty("case_type")]
        [STJS.JsonPropertyName("case_type")]
        public string CaseType { get; set; }

        /// <summary>
        /// The card network's specific dispute reason code, which maps to one of Stripe's primary
        /// dispute categories to simplify response guidance. The <a
        /// href="https://stripe.com/docs/disputes/categories#network-code-map">Network code map</a>
        /// lists all available dispute reason codes by network.
        /// </summary>
        [JsonProperty("network_reason_code")]
        [STJS.JsonPropertyName("network_reason_code")]
        public string NetworkReasonCode { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputePaymentMethodDetailsCard : StripeEntity<DisputePaymentMethodDetailsCard>
    {
        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>diners</c>, <c>discover</c>, <c>eftpos_au</c>,
        /// <c>jcb</c>, <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The card network's specific dispute reason code, which maps to one of Stripe's primary
        /// dispute categories to simplify response guidance. The <a
        /// href="https://stripe.com/docs/disputes/categories#network-code-map">Network code map</a>
        /// lists all available dispute reason codes by network.
        /// </summary>
        [JsonProperty("network_reason_code")]
        public string NetworkReasonCode { get; set; }
    }
}

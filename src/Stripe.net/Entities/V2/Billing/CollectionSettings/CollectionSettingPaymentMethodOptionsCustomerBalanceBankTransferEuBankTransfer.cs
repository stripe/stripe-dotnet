// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CollectionSettingPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer : StripeEntity<CollectionSettingPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer>
    {
        /// <summary>
        /// The desired country code of the bank account information.
        /// One of: <c>BE</c>, <c>DE</c>, <c>ES</c>, <c>FR</c>, <c>IE</c>, or <c>NL</c>.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferOriginPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Includes additional payment method options if the destination is a us_bank_account.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public InboundTransferOriginPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}

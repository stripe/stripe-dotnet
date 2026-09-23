// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferOriginPaymentMethodOptionsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Specify details about the ACH transaction.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public InboundTransferOriginPaymentMethodOptionsUsBankAccountAchOptions Ach { get; set; }
    }
}

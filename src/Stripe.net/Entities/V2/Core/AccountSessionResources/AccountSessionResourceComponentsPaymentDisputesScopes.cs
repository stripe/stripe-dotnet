// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionResourceComponentsPaymentDisputesScopes : StripeEntity<AccountSessionResourceComponentsPaymentDisputesScopes>
    {
        /// <summary>
        /// Whether to allow managing destination and on-behalf-of charges.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_destination_on_behalf_of_charges")]
        [STJS.JsonPropertyName("manage_destination_on_behalf_of_charges")]
        public string ManageDestinationOnBehalfOfCharges { get; set; }

        /// <summary>
        /// Whether to allow managing payment disputes.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_payment_disputes")]
        [STJS.JsonPropertyName("manage_payment_disputes")]
        public string ManagePaymentDisputes { get; set; }

        /// <summary>
        /// Whether to allow refunding payments.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_refund_payments")]
        [STJS.JsonPropertyName("manage_refund_payments")]
        public string ManageRefundPayments { get; set; }

        /// <summary>
        /// Whether to allow managing Smart Disputes.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_smart_disputes")]
        [STJS.JsonPropertyName("manage_smart_disputes")]
        public string ManageSmartDisputes { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountRejectOptions : BaseOptions
    {
        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>configuration.card_creator</c>, <c>configuration.customer</c>,
        /// <c>configuration.developer</c>, <c>configuration.merchant</c>,
        /// <c>configuration.recipient</c>, <c>configuration.money_manager</c>, <c>defaults</c>,
        /// <c>future_requirements</c>, <c>identity</c>, or <c>requirements</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Operations that remain unaffected by the rejection. Repeated requests replace the
        /// previous set; omitting this field clears any preserved operations.
        /// One of: <c>payouts</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("preserve_operations")]
        [STJS.JsonPropertyName("preserve_operations")]
        public List<string> PreserveOperations { get; set; }

        /// <summary>
        /// The reason for rejecting the Account. Repeated requests replace the previously recorded
        /// reason.
        /// One of: <c>credit</c>, <c>fraud_no_intent_to_fulfill</c>, <c>fraud_other</c>,
        /// <c>fraud_payment_method_casher</c>, <c>fraud_payment_method_tester</c>, <c>other</c>, or
        /// <c>terms_of_service</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}

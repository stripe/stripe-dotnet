// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSignalListOptions : V2.ListOptions
    {
        /// <summary>
        /// The account or customer to list signals for. Exactly one of account_details.account or
        /// account_details.customer must be provided.
        /// </summary>
        [JsonProperty("account_details")]
        [STJS.JsonPropertyName("account_details")]
        public AccountSignalListAccountDetailsOptions AccountDetails { get; set; }

        /// <summary>
        /// Signal types to filter by.
        /// One of: <c>account_takeover</c>, <c>customer_risk</c>, <c>fraudulent_merchant</c>,
        /// <c>fraudulent_website</c>, <c>merchant_delinquency</c>,
        /// <c>payment_delinquency_exposure</c>, <c>user_account_sharing</c>,
        /// <c>user_merchant_fit</c>, or <c>user_multi_accounting</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public List<string> Type { get; set; }
    }
}

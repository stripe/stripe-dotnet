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
        /// One of: <c>fraudulent_merchant</c>, <c>merchant_delinquency</c>, or
        /// <c>payment_delinquency_exposure</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public List<string> Type { get; set; }
    }
}

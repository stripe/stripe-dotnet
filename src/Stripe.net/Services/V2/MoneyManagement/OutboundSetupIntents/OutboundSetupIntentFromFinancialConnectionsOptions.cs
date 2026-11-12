// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundSetupIntentFromFinancialConnectionsOptions : BaseOptions
    {
        /// <summary>
        /// Used to create a US Bank Account directly from a Financial Connections Account.
        /// </summary>
        [JsonProperty("financial_connections_account")]
        [STJS.JsonPropertyName("financial_connections_account")]
        public string FinancialConnectionsAccount { get; set; }

        /// <summary>
        /// Used to create a US Bank Account from the internal-only "payment account" associated
        /// with a Financial Connections Session. Only useful when the Session completed with manual
        /// entry (i.e. there is no Financial Connections Account).
        /// </summary>
        [JsonProperty("financial_connections_session")]
        [STJS.JsonPropertyName("financial_connections_session")]
        public string FinancialConnectionsSession { get; set; }

        /// <summary>
        /// Specify which type of outbound money movement this credential should be set up for
        /// (payment | transfer). If not provided, defaults to payment.
        /// One of: <c>payment</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("usage_intent")]
        [STJS.JsonPropertyName("usage_intent")]
        public string UsageIntent { get; set; }
    }
}

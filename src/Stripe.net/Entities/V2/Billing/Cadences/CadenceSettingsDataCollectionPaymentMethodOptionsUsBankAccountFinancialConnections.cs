// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceSettingsDataCollectionPaymentMethodOptionsUsBankAccountFinancialConnections : StripeEntity<CadenceSettingsDataCollectionPaymentMethodOptionsUsBankAccountFinancialConnections>
    {
        /// <summary>
        /// Provide filters for the linked accounts that the customer can select for the payment
        /// method.
        /// </summary>
        [JsonProperty("filters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("filters")]
#endif
        public CadenceSettingsDataCollectionPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters Filters { get; set; }

        /// <summary>
        /// The list of permissions to request. If this parameter is passed, the
        /// <c>payment_method</c> permission must be included.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("permissions")]
#endif
        public List<string> Permissions { get; set; }

        /// <summary>
        /// List of data features that you would like to retrieve upon account creation.
        /// One of: <c>balances</c>, <c>ownership</c>, or <c>transactions</c>.
        /// </summary>
        [JsonProperty("prefetch")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prefetch")]
#endif
        public List<string> Prefetch { get; set; }
    }
}

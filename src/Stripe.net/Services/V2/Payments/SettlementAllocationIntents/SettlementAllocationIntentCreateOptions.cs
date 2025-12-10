// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SettlementAllocationIntentCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The amount and currency of the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public SettlementAllocationIntentCreateAmountOptions Amount { get; set; }

        /// <summary>
        /// Expected date when we expect to receive the funds.
        /// </summary>
        [JsonProperty("expected_settlement_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_settlement_date")]
#endif
        public DateTime? ExpectedSettlementDate { get; set; }

        /// <summary>
        /// FinancialAccount where the funds are expected to land / FinancialAccount to map this
        /// SettlementAllocationIntent to.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Metadata associated with the SettlementAllocationIntent.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Reference for the settlement intent . Max 255 characters . The reference used by PSP to
        /// send funds to Stripe .
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif
        public string Reference { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Main Contract resource representing a comprehensive billing agreement.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Contract : StripeEntity<Contract>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// The ID of the contract object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The billing cycle anchor for the contract.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        public ContractBillingCycleAnchor BillingCycleAnchor { get; set; }

        /// <summary>
        /// The billing settings for the contract.
        /// </summary>
        [JsonProperty("billing_settings")]
        [STJS.JsonPropertyName("billing_settings")]
        public ContractBillingSettings BillingSettings { get; set; }

        /// <summary>
        /// A unique user-provided contract number e.g. C-2026-0001.
        /// </summary>
        [JsonProperty("contract_number")]
        [STJS.JsonPropertyName("contract_number")]
        public string ContractNumber { get; set; }

        /// <summary>
        /// Timestamp of when the object was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The currency of the contract.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the customer associated with the contract.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The one-time fees of the contract. Only populated when <c>one_time_fees</c> is passed in
        /// the <c>include</c> parameter.
        /// </summary>
        [JsonProperty("one_time_fees")]
        [STJS.JsonPropertyName("one_time_fees")]
        public ContractOneTimeFees OneTimeFees { get; set; }

        /// <summary>
        /// The pricing lines of the contract. Only populated when <c>pricing_lines</c> is passed in
        /// the <c>include</c> parameter.
        /// </summary>
        [JsonProperty("pricing_lines")]
        [STJS.JsonPropertyName("pricing_lines")]
        public ContractPricingLines PricingLines { get; set; }

        /// <summary>
        /// The pricing overrides of the contract. Only populated when <c>pricing_overrides</c> is
        /// passed in the <c>include</c> parameter.
        /// </summary>
        [JsonProperty("pricing_overrides")]
        [STJS.JsonPropertyName("pricing_overrides")]
        public ContractPricingOverrides PricingOverrides { get; set; }

        /// <summary>
        /// The current status of the contract.
        /// One of: <c>active</c>, <c>canceled</c>, <c>draft</c>, or <c>ended</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Historical timestamps of when the contract transitioned into each status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public ContractStatusTransitions StatusTransitions { get; set; }
    }
}

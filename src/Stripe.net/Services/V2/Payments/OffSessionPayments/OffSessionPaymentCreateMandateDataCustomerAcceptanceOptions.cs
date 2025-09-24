// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreateMandateDataCustomerAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// The time at which the customer accepted the Mandate.
        /// </summary>
        [JsonProperty("accepted_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accepted_at")]
#endif
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// The type of customer acceptance information included with the Mandate.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionListOptions : ListOptions
    {
        /// <summary>
        /// A string to reference this user. This can be a customer ID, a session ID, or similar,
        /// and can be used to reconcile this verification with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_reference_id")]
#endif
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Only return VerificationSessions that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Customer ID.
        /// </summary>
        [JsonProperty("related_customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_customer")]
#endif
        public string RelatedCustomer { get; set; }

        /// <summary>
        /// The ID of the Account representing a customer.
        /// </summary>
        [JsonProperty("related_customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_customer_account")]
#endif
        public string RelatedCustomerAccount { get; set; }

        /// <summary>
        /// Only return VerificationSessions with this status. <a
        /// href="https://docs.stripe.com/identity/how-sessions-work">Learn more about the lifecycle
        /// of sessions</a>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_input</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}

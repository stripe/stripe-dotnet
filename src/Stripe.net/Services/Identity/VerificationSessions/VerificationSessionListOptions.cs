// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;

    public class VerificationSessionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A string to reference this user. This can be a customer ID, a session ID, or similar,
        /// and can be used to reconcile this verification with your internal systems.
        /// </summary>
        [JsonProperty("client_reference_id")]
        public string ClientReferenceId { get; set; }

        /// <summary>
        /// Only return VerificationSessions with this status. <a
        /// href="https://stripe.com/docs/identity/how-sessions-work">Learn more about the lifecycle
        /// of sessions</a>.
        /// One of: <c>canceled</c>, <c>processing</c>, <c>requires_input</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

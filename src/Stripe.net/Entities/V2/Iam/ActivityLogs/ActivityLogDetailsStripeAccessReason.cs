// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsStripeAccessReason : StripeEntity<ActivityLogDetailsStripeAccessReason>
    {
        /// <summary>
        /// Set when access is granted through an access request.
        /// </summary>
        [JsonProperty("access_request")]
        [STJS.JsonPropertyName("access_request")]
        public ActivityLogDetailsStripeAccessReasonAccessRequest AccessRequest { get; set; }

        /// <summary>
        /// Set when access is granted through a support relationship.
        /// </summary>
        [JsonProperty("support_relationship")]
        [STJS.JsonPropertyName("support_relationship")]
        public ActivityLogDetailsStripeAccessReasonSupportRelationship SupportRelationship { get; set; }

        /// <summary>
        /// Set when access is granted through a support ticket.
        /// </summary>
        [JsonProperty("support_ticket")]
        [STJS.JsonPropertyName("support_ticket")]
        public ActivityLogDetailsStripeAccessReasonSupportTicket SupportTicket { get; set; }

        /// <summary>
        /// The type of reason for granting access.
        /// One of: <c>access_request</c>, <c>support_relationship</c>, or <c>support_ticket</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A ProviderConnectionRequest represents an in-progress account-linking workflow. Once the
    /// workflow completes, <c>provider_connection</c> is populated with the resulting
    /// ProviderConnection.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderConnectionRequest : StripeEntity<ProviderConnectionRequest>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the provider connection request.
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
        /// Time at which the provider connection request was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime? Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Error from the account-linking workflow, set when request_status is ERROR.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public ProviderConnectionRequestError Error { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Schema describing the information the provider still needs, set when request_status is
        /// NEEDS_INFORMATION.
        /// </summary>
        [JsonProperty("needs_information_schema")]
        [STJS.JsonPropertyName("needs_information_schema")]
        public Dictionary<string, object> NeedsInformationSchema { get; set; }

        /// <summary>
        /// Identifier of the provider this connection request is linked to.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// A ProviderConnection represents a link between a project and a provider account that
        /// resources can be created against; unlinking it prevents further resource creation.
        /// </summary>
        [JsonProperty("provider_connection")]
        [STJS.JsonPropertyName("provider_connection")]
        public ProviderConnection ProviderConnection { get; set; }

        /// <summary>
        /// URL the caller should redirect to in order to continue the account-linking workflow.
        /// </summary>
        [JsonProperty("redirect_url")]
        [STJS.JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Status of the underlying account-linking workflow. Unset once the workflow completes;
        /// see provider_connection for the resulting connection's status.
        /// One of: <c>complete</c>, <c>error</c>, <c>needs_information</c>, <c>pending_auth</c>, or
        /// <c>requested</c>.
        /// </summary>
        [JsonProperty("request_status")]
        [STJS.JsonPropertyName("request_status")]
        public string RequestStatus { get; set; }

        /// <summary>
        /// Scopes requested for the account-linking workflow.
        /// </summary>
        [JsonProperty("scopes")]
        [STJS.JsonPropertyName("scopes")]
        public List<string> Scopes { get; set; }
    }
}

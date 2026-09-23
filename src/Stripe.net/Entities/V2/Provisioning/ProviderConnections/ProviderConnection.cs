// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A ProviderConnection represents a link between a project and a provider account that
    /// resources can be created against; unlinking it prevents further resource creation.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProviderConnection : StripeEntity<ProviderConnection>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the provider connection.
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
        /// Time at which the provider connection was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime? Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Identifier of the provider this connection is linked to.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Identifier of the connected account at the provider, if one has been established.
        /// </summary>
        [JsonProperty("provider_account")]
        [STJS.JsonPropertyName("provider_account")]
        public string ProviderAccount { get; set; }

        /// <summary>
        /// Details about the connected provider account.
        /// </summary>
        [JsonProperty("provider_account_details")]
        [STJS.JsonPropertyName("provider_account_details")]
        public ProviderConnectionProviderAccountDetails ProviderAccountDetails { get; set; }

        /// <summary>
        /// Current status of the provider connection.
        /// One of: <c>active</c>, <c>expired</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}

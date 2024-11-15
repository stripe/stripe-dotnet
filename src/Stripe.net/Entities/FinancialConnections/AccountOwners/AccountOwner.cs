// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Describes an owner of an account.
    /// </summary>
    public class AccountOwner : StripeEntity<AccountOwner>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; }

        /// <summary>
        /// The email address of the owner.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif

        public string Email { get; set; }

        /// <summary>
        /// The full name of the owner.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        /// <summary>
        /// The ownership object that this owner belongs to.
        /// </summary>
        [JsonProperty("ownership")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ownership")]
#endif

        public string Ownership { get; set; }

        /// <summary>
        /// The raw phone number of the owner.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif

        public string Phone { get; set; }

        /// <summary>
        /// The raw physical address of the owner.
        /// </summary>
        [JsonProperty("raw_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("raw_address")]
#endif

        public string RawAddress { get; set; }

        /// <summary>
        /// The timestamp of the refresh that updated this owner.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refreshed_at")]
#endif

        public DateTime? RefreshedAt { get; set; }
    }
}

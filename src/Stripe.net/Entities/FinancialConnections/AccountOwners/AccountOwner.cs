// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Describes an owner of an account.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountOwner : StripeEntity<AccountOwner>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The email address of the owner.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The full name of the owner.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The ownership object that this owner belongs to.
        /// </summary>
        [JsonProperty("ownership")]
        [STJS.JsonPropertyName("ownership")]
        public string Ownership { get; set; }

        /// <summary>
        /// The raw phone number of the owner.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The raw physical address of the owner.
        /// </summary>
        [JsonProperty("raw_address")]
        [STJS.JsonPropertyName("raw_address")]
        public string RawAddress { get; set; }

        /// <summary>
        /// The timestamp of the refresh that updated this owner.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("refreshed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? RefreshedAt { get; set; }
    }
}

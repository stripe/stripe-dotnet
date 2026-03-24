// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceOwner : StripeEntity<SourceOwner>
    {
        /// <summary>
        /// Owner's address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Owner's email address.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Owner's full name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Owner's phone number (including extension).
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Verified owner's address. Verified values are verified or provided by the payment method
        /// directly (and if supported) at the time of authorization or settlement. They cannot be
        /// set or mutated.
        /// </summary>
        [JsonProperty("verified_address")]
        [STJS.JsonPropertyName("verified_address")]
        public Address VerifiedAddress { get; set; }

        /// <summary>
        /// Verified owner's email address. Verified values are verified or provided by the payment
        /// method directly (and if supported) at the time of authorization or settlement. They
        /// cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_email")]
        [STJS.JsonPropertyName("verified_email")]
        public string VerifiedEmail { get; set; }

        /// <summary>
        /// Verified owner's full name. Verified values are verified or provided by the payment
        /// method directly (and if supported) at the time of authorization or settlement. They
        /// cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_name")]
        [STJS.JsonPropertyName("verified_name")]
        public string VerifiedName { get; set; }

        /// <summary>
        /// Verified owner's phone number (including extension). Verified values are verified or
        /// provided by the payment method directly (and if supported) at the time of authorization
        /// or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_phone")]
        [STJS.JsonPropertyName("verified_phone")]
        public string VerifiedPhone { get; set; }
    }
}

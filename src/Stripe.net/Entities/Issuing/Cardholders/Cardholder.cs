namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Cardholder : StripeEntity<Cardholder>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object’s type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The cardholder’s billing address.
        /// </summary>
        [JsonProperty("billing")]
        public Billing Billing { get; set; }

        /// <summary>
        /// Additional information about a business entity cardholder.
        /// </summary>
        [JsonProperty("company")]
        public CardholderCompany Company { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The cardholder’s email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Additional information about an individual cardholder.
        /// </summary>
        [JsonProperty("individual")]
        public CardholderIndividual Individual { get; set; }

        /// <summary>
        /// Whether or not this cardholder is the default cardholder.
        /// </summary>
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a subscription object.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The cardholder’s name. This will be printed on cards issued to them.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [Obsolete("Use PhoneNumber instead")]
        [JsonIgnore]
        public string PhonNumber
        {
            get => this.PhoneNumber;
            set => this.PhoneNumber = value;
        }

        /// <summary>
        /// The cardholder’s phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Information about verification requirements for the cardholder, including what information needs to be collected.
        /// </summary>
        [JsonProperty("requirements")]
        public CardholderRequirements Requirements { get; set; }

        /// <summary>
        /// One of <c>active</c>, <c>inactive</c>, or <c>blocked</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// One of <c>individual</c> or <c>business_entity</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

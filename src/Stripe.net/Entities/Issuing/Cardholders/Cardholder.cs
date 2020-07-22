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
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The cardholder's billing address.
        /// </summary>
        [JsonProperty("billing")]
        public CardholderBilling Billing { get; set; }

        /// <summary>
        /// Additional information about a business entity cardholder.
        /// </summary>
        [JsonProperty("company")]
        public CardholderCompany Company { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The cardholder's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Additional information about an individual cardholder.
        /// </summary>
        [JsonProperty("individual")]
        public CardholderIndividual Individual { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value
        /// <c>false</c> if the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format. Individual keys can be
        /// unset by posting an empty value to them. All keys can be unset by posting an empty
        /// value to metadata.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The cardholder's name. This will be printed on cards issued to them.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The cardholder's phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Information about verification requirements for the cardholder, including what information needs to be collected.
        /// </summary>
        [JsonProperty("requirements")]
        public CardholderRequirements Requirements { get; set; }

        /// <summary>
        /// Spending rules that give you control over how your cardholders can make charges.
        /// </summary>
        [JsonProperty("spending_controls")]
        public CardholderSpendingControls SpendingControls { get; set; }

        /// <summary>
        /// One of <c>active</c>, <c>inactive</c>, or <c>blocked</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// One of <c>individual</c> or <c>company</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

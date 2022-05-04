// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountOwner : StripeEntity<AccountOwner>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The email address of the owner.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The full name of the owner.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The ownership object that this owner belongs to.
        /// </summary>
        [JsonProperty("ownership")]
        public string Ownership { get; set; }

        /// <summary>
        /// The raw phone number of the owner.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The raw physical address of the owner.
        /// </summary>
        [JsonProperty("raw_address")]
        public string RawAddress { get; set; }

        /// <summary>
        /// The timestamp of the refresh that updated this owner.
        /// </summary>
        [JsonProperty("refreshed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? RefreshedAt { get; set; }
    }
}

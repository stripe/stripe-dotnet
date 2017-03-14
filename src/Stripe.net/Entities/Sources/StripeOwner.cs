using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeOwner : StripeEntity
    {
        /// <summary>
        /// Owner’s address.
        /// </summary>
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        /// <summary>
        /// Owner’s email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Owner’s full name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Owner’s phone number (including extension).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Verified owner's address.
        /// </summary>
        [JsonProperty("verified_address")]
        public StripeAddress VerifiedAddress { get; set; }

        /// <summary>
        /// Verified owner’s email address.
        /// </summary>
        [JsonProperty("verified_email")]
        public string VerifiedEmail { get; set; }

        /// <summary>
        /// Verified owner’s full name.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }

        /// <summary>
        /// Verified owner’s phone number (including extension).
        /// </summary>
        [JsonProperty("verified_phone")]
        public string VerifiedPhone { get; set; }
    }
}

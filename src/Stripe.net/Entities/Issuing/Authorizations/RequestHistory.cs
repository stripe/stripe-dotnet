namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class RequestHistory : StripeEntity<RequestHistory>
    {
        /// <summary>
        /// The total amount in the card's currency that was authorized or rejected.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Whether this request was approved.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [Obsolete("This field is considered deprecated.")]
        [JsonProperty("authorized_amount")]
        public long AuthorizedAmount { get; set; }

        [Obsolete("This field is considered deprecated.")]
        [JsonProperty("authorized_currency")]
        public string AuthorizedCurrency { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [Obsolete("This field is considered deprecated.")]
        [JsonProperty("held_amount")]
        public long HeldAmount { get; set; }

        [Obsolete("This field is considered deprecated.")]
        [JsonProperty("held_currency")]
        public string HeldCurrency { get; set; }

        /// <summary>
        /// The total amount that was authorized or rejected in the local
        /// <see cref="MerchantCurrency"/>.
        /// </summary>
        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        /// <summary>
        /// The currency of the held amount. This will always be the card currency.
        /// </summary>
        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        /// <summary>
        /// The reason for the approval or decline.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        [Obsolete]
        [JsonProperty("violated_authorization_controls")]
        public List<AuthorizationRequestHistoryViolatedAuthorizationControl> ViolatedAuthorizationControls { get; set; }
    }
}

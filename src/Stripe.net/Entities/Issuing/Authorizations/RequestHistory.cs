namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class RequestHistory : StripeEntity<RequestHistory>
    {
        /// <summary>
        /// Whether this request was approved.
        /// </summary>
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// The amount that was authorized at the time of this request.
        /// </summary>
        [JsonProperty("authorized_amount")]
        public long AuthorizedAmount { get; set; }

        /// <summary>
        /// The currency that was presented to the cardholder for the authorization.
        /// </summary>
        [JsonProperty("authorized_currency")]
        public string AuthorizedCurrency { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The amount Stripe held from your account to fund the authorization, if the request was
        /// approved.
        /// </summary>
        [JsonProperty("held_amount")]
        public long HeldAmount { get; set; }

        /// <summary>
        /// The currency of the held amount.
        /// </summary>
        [JsonProperty("held_currency")]
        public string HeldCurrency { get; set; }

        /// <summary>
        /// The reason for the approval or decline.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// When an authorization is declined due to authorization controls, this list contains
        /// details about the authorization controls that were violated. Otherwise, it is empty.
        /// </summary>
        [JsonProperty("violated_authorization_controls")]
        public List<AuthorizationRequestHistoryViolatedAuthorizationControl> ViolatedAuthorizationControls { get; set; }
    }
}

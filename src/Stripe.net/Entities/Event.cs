namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Event : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("data")]
        public EventData Data { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("pending_webhooks")]
        public int PendingWebhooks { get; set; }

        #region Request

        /*
         * This works like expandable properties. it's used for the event having just a string for the request id or
         * the Request object for requests after the 2017-05-25 api release
         */

        public string RequestId { get; set; }

        [JsonIgnore]
        public EventRequest Request { get; set; }

        [JsonProperty("request")]
        internal object InternalRequest
        {
            set
            {
                StringOrObject<EventRequest>.Map(value, s => this.RequestId = s, o => this.Request = o);
            }
        }
        #endregion

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

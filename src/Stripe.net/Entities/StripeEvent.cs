using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeEvent : StripeEntityWithId
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("data")]
        public StripeEventData Data { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("pending_webhooks")]
        public int PendingWebhooks { get; set; }

        #region Request
        // this works like expandable properties. it's used for the event having just a string for the request id or
        // the Request object for requests after the 2017-05-25 api release

        public string RequestId { get; set; }

        [JsonIgnore]
        public StripeEventRequest Request { get; set; }

        [JsonProperty("request")]
        internal object InternalRequest
        {
            set
            {
                StringOrObject<StripeEventRequest>.Map(value, s => RequestId = s, o => Request = o);
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeThreeDSecureCreateOptions
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        public bool UseStripeJsIframe { get; set; }

        public string ReturnUrl { get; set; }

        [JsonProperty("return_url")]
        internal string ReturnUrlInternal
        {
            get { return UseStripeJsIframe ? "_callback" : ReturnUrl; }
        }

        [JsonProperty("card")]
        public string CardId { get; set; }
    }
}

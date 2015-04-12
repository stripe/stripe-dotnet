using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;

namespace Stripe
{
    public class StripeCustomer : StripeObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool? LiveMode { get; set; }

        [JsonProperty("cards")]
        public StripeCardList StripeCardList { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("account_balance")]
        public int? AccountBalance { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        public string StripeDefaultCardId { get; set; }
        public StripeCard StripeDefaultCard { get; set; }

        [JsonProperty("default_card")]
        internal object InternalDefaultCard
        {
            set
            {
                ExpandableProperty<StripeCard>.Map(value, s => StripeDefaultCardId = s, o => StripeDefaultCard = o);
            }
        }

        [JsonProperty("delinquent")]
        public bool Delinquent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public StripeDiscount StripeDiscount { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("subscriptions")]
        public StripeSubscriptionList StripeSubscriptionList { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }
    }
}
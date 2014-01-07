using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeCustomer
	{
	    public StripeCustomer()
	    {
	        Metadata = new Dictionary<string, string>(10);
	    }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("account_balance")]
		public int? AccountBalance { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		[JsonProperty("deleted")]
		public bool? Deleted { get; set; }

		/// <summary>
		/// Whether or not the latest charge for the customer's latest invoice has failed.
		/// </summary>
		[JsonProperty("delinquent")]
		public bool? Delinquent { get; set; }

		/// <summary>
		/// Describes the current discount active on the customer, if there is one.
		/// </summary>
		[JsonProperty("discount")]
		public StripeDiscount StripeDiscount { get; set; }

		/// <summary>
		/// Hash describing the current subscription on the customer, if there is one. If the
		/// customer has no current subscription, this will be null.
		/// </summary>
		[Obsolete("Use StripeSubscriptions")]
		[JsonProperty("subscription")]
		public StripeSubscription StripeSubscription { get; set; }

        /// <summary>
        /// Populated if the customer has multiple subscriptions.
        /// </summary>
        [JsonProperty("subscriptions")]
        public StripeSubscriptionList StripeSubscriptions { get; set; }

        // Do not add JsonProperty as this is managed by the InternalStripeDefaultCard field
		public string StripeDefaultCardId { get; private set; }
        // Do not add JsonProperty as this is managed by the InternalStripeDefaultCard field
        public StripeCard StripeDefaultCard { get; private set; }

        [JsonProperty("default_card")]
	    internal object InternalStripeDefaultCard
	    {
	        get { return StripeDefaultCard; }
            set
            {
                if (value is JObject)
                {
                    StripeDefaultCard = ((JToken)value).ToObject<StripeCard>();
                    StripeDefaultCardId = StripeDefaultCard.Id;
                }
                else
                {
                    StripeDefaultCardId = value.ToString();
                    StripeDefaultCard = null;
                }
            }
	    }

		[JsonProperty("cards")]
		public StripeCardList StripeCardList { get; set; }

        /// <summary>
        /// Stripe only allows 10 kvps
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string,string> Metadata { get; set; }
	}
}
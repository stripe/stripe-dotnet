using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeEvent
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Created { get; set; }

		[JsonProperty("data")]
		public StripeEventData Data { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("user_id")]
		public string UserId { get; set; }

		/// <summary>
		/// Number of webhooks yet to be delivered successfully (return a 20x
		/// response) to the URLs you've specified.
		/// </summary>
		[JsonProperty("pending_webhooks")]
		public int PendingWebhooks { get; set; }

		/// <summary>
		/// ID of the API request that caused the event. If null, the event was
		/// automatic (e.g. Stripes automatic subscription handling). Request logs
		/// are available in the dashboard but currently not in the API.
		/// </summary>
		/// <remarks>Note: this property is populated for events on or after April
		/// 23, 2013.</remarks>
		[JsonProperty("request")]
		public string Request { get; set; }
	}
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeTransfer : StripeTransferAccount
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("livemode")]
		public bool LiveMode { get; set; }

		/// <summary>
		/// Date that the transfer was initiated. If the transfer is pending, the date the transfer
		/// is scheduled to go out.
		/// </summary>
		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Date { get; set; }

		/// <summary>
		/// Amount (in cents) to be transferred.
		/// </summary>
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		/// <summary>
		/// Current status of the transfer ('paid', 'pending' or 'failed'). A transfer will be 'pending'
		/// until it is submitted, at which point it becomes 'paid'. If it does not go through successfully,
		/// its status will change to 'failed'.
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// Three-letter ISO currency code.
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }

		/// <summary>
		/// Internal-only description of the transfer.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("other_transfers")]
		public List<string> OtherTransfers { get; set; }

		[JsonProperty("summary")]
		public StripeTransferSummary Summary { get; set; }

		[JsonProperty("deleted")]
		public bool? Deleted { get; set; }
	}
}
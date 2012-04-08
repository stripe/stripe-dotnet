using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTransferSummary
	{
		[JsonProperty("adjustment_count")]
		public int? AdjustmentCount { get; set; }

		[JsonProperty("adjustment_gross")]
		public int? AdjustmentAmountInCents { get; set; }

		[JsonProperty("charge_count")]
		public int? ChargeCount { get; set; }

		[JsonProperty("charge_fees")]
		public int? ChargeFeesInCents { get; set; }

		[JsonProperty("charge_gross")]
		public int? ChargeAmountInCents { get; set; }

		[JsonProperty("net")]
		public int? NetAmountInCents { get; set; }

		[JsonProperty("refund_count")]
		public int? RefundCount { get; set; }

		[JsonProperty("refund_fees")]
		public int? RefundFeesInCents { get; set; }

		[JsonProperty("refund_gross")]
		public int? RefundAmountInCents { get; set; }

		[JsonProperty("validation_count")]
		public int? ValidationCount { get; set; }

		[JsonProperty("validation_fees")]
		public int? ValidationFeeAmountInCents { get; set; }
	}
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTransferSummary
	{
		[JsonProperty("charge_gross")]
		public int? ChargeGrossInCents { get; set; }

		[JsonProperty("charge_fees")]
		public int? ChargeFeesInCents { get; set; }

		[JsonProperty("charge_count")]
		public int? ChargeCount { get; set; }

		[JsonProperty("refund_gross")]
		public int? RefundGrossInCents { get; set; }

		[JsonProperty("refund_fees")]
		public int? RefundFeesInCents { get; set; }

		[JsonProperty("refund_count")]
		public int? RefundCount { get; set; }

		[JsonProperty("validation_fees")]
		public int? ValidationFeesInCents { get; set; }

		[JsonProperty("validation_count")]
		public int? ValidationCount { get; set; }

		[JsonProperty("adjustment_gross")]
		public int? AdjustmentGrossInCents { get; set; }

		[JsonProperty("adjustment_fees")]
		public int? AdjustmentFeesInCents { get; set; }

		[JsonProperty("adjustment_count")]
		public int? AdjustmentCount { get; set; }

		[JsonProperty("net")]
		public int? NetInCents { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("collected_fee_gross")]
		public int? CollectedFeeGrossInCents { get; set; }

		[JsonProperty("collected_fee_count")]
		public int? CollectedFeeCount { get; set; }

		[JsonProperty("collected_fee_refund_gross")]
		public int? CollectedFeeRefundGrossInCents { get; set; }

		[JsonProperty("collected_fee_refund_count")]
		public int? CollectedFeeRefundCount { get; set; }
	}
}

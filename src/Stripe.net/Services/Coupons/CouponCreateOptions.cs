namespace Stripe
{
    using System;
    using System.Collections.Generic;

    using Stripe.Infrastructure;

    public class CouponCreateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("id")]
        public string Id { get; set; }

        [FormProperty("amount_off")]
        public int? AmountOff { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("percent_off")]
        public decimal? PercentOff { get; set; }

        [FormProperty("duration")]
        public string Duration { get; set; }

        [FormProperty("duration_in_months")]
        public int? DurationInMonths { get; set; }

        [FormProperty("max_redemptions")]
        public int? MaxRedemptions { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("name")]
        public string Name { get; set; }

        [FormProperty("redeem_by")]
        public DateTime? RedeemBy { get; set; }
    }
}

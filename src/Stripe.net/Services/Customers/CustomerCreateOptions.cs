namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CustomerCreateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("account_balance")]
        public int? AccountBalance { get; set; }

        [FormProperty("coupon")]
        public string CouponId { get; set; }

        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("email")]
        public string Email { get; set; }

        [FormProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("plan")]
        public string PlanId { get; set; }

        [FormProperty("quantity")]
        public int? Quantity { get; set; }

        [FormProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        [FormProperty("source")]
        public string SourceToken { get; set; }

        [FormProperty("source")]
        public CardCreateNestedOptions SourceCard { get; set; }

        [FormProperty("tax_info")]
        public CustomerTaxInfoOptions TaxInfo { get; set; }

        [FormProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [FormProperty("validate")]
        public bool? Validate { get; set; }

        #region Trial End

        public DateTime? TrialEnd { get; set; }

        public bool EndTrialNow { get; set; }

        [FormProperty("trial_end")]
        internal string TrialEndInternal
        {
            get
            {
                if (this.EndTrialNow)
                {
                    return "now";
                }
                else if (this.TrialEnd.HasValue)
                {
                    return EpochTime.ConvertDateTimeToEpoch(this.TrialEnd.Value).ToString();
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion
    }
}

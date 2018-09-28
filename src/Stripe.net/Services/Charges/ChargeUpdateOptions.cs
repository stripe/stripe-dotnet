namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ChargeUpdateOptions : BaseOptions, ISupportMetadata
    {
        [FormProperty("description")]
        public string Description { get; set; }

        [FormProperty("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        [FormProperty("fraud_details")]
        public Dictionary<string, string> FraudDetails { get; set; }

        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [FormProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// Shipping information for the charge. Helps prevent fraud on charges for physical goods. For more information, see the Charge object documentation.
        /// </summary>
        [FormProperty("shipping")]
        public ChargeShippingOptions Shipping { get; set; }
    }
}

namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class PaymentIntentCaptureOptions : BaseOptions
    {
        [FormProperty("amount_to_capture")]
        public int? AmountToCapture { get; set; }

        [FormProperty("application_fee_amount")]
        public int? ApplicationFeeAmount { get; set; }

        [FormProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }
    }
}

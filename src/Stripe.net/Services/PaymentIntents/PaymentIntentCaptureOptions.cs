namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentCaptureOptions : StripeBaseOptions
    {
        [JsonProperty("amount_to_capture")]
        public int? AmountToCapture { get; set; }

        [JsonProperty("application_fee_amount")]
        public int? ApplicationFeeAmount { get; set; }

        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }
    }
}

namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public enum BalanceTransactionSourceType
    {
        ApplicationFee,
        Charge,
        Dispute,
        Payout,
        Refund,
        Transfer,
        TransferReversal,
        Topup,
        Unknown,
    }

    [JsonConverter(typeof(BalanceTransactionSourceConverter))]
    public class BalanceTransactionSource : StripeEntityWithId
    {
        public BalanceTransactionSourceType Type { get; set; }

        public StripeApplicationFee ApplicationFee { get; set; }

        public StripeCharge Charge { get; set; }

        public StripeDispute Dispute { get; set; }

        public StripePayout Payout { get; set; }

        public StripeRefund Refund { get; set; }

        public StripeTransfer Transfer { get; set; }

        public StripeTransferReversal TransferReversal { get; set; }

        public StripeTopup Topup { get; set; }
    }
}

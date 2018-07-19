namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public enum BalanceTransactionSourceType
    {
        ApplicationFee,
        Charge,
        Dispute,
        IssuingAuthorization,
        IssuingTransaction,
        Payout,
        Refund,
        Topup,
        Transfer,
        TransferReversal,
        Unknown,
    }

    [JsonConverter(typeof(BalanceTransactionSourceConverter))]
    public class BalanceTransactionSource : StripeEntityWithId
    {
        public BalanceTransactionSourceType Type { get; set; }

        public StripeApplicationFee ApplicationFee { get; set; }

        public StripeCharge Charge { get; set; }

        public StripeDispute Dispute { get; set; }

        public Issuing.Authorization IssuingAuthorization { get; set; }

        public Issuing.Transaction IssuingTransaction { get; set; }

        public StripePayout Payout { get; set; }

        public StripeRefund Refund { get; set; }

        public StripeTransfer Transfer { get; set; }

        public StripeTransferReversal TransferReversal { get; set; }

        public StripeTopup Topup { get; set; }
    }
}

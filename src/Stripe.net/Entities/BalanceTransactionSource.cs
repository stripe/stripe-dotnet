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

        public ApplicationFee ApplicationFee { get; set; }

        public Charge Charge { get; set; }

        public Dispute Dispute { get; set; }

        public Issuing.Authorization IssuingAuthorization { get; set; }

        public Issuing.Transaction IssuingTransaction { get; set; }

        public Payout Payout { get; set; }

        public Refund Refund { get; set; }

        public Transfer Transfer { get; set; }

        public TransferReversal TransferReversal { get; set; }

        public Topup Topup { get; set; }
    }
}

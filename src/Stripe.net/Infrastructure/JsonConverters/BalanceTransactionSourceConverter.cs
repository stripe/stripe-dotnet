namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;

    internal class BalanceTransactionSourceConverter : AbstractStripeObjectConverter<IBalanceTransactionSource>
    {
        protected override Dictionary<string, Func<string, IBalanceTransactionSource>> ObjectsToMapperFuncs
            => new Dictionary<string, Func<string, IBalanceTransactionSource>>
        {
            { "application_fee", Mapper<ApplicationFee>.MapFromJson },
            { "charge", Mapper<Charge>.MapFromJson },
            { "dispute", Mapper<Dispute>.MapFromJson },
            { "fee_refund", Mapper<ApplicationFeeRefund>.MapFromJson },
            { "issuing.authorization", Mapper<Issuing.Authorization>.MapFromJson },
            { "issuing.transaction", Mapper<Issuing.Transaction>.MapFromJson },
            { "payout", Mapper<Payout>.MapFromJson },
            { "refund", Mapper<Refund>.MapFromJson },
            { "topup", Mapper<Topup>.MapFromJson },
            { "transfer", Mapper<Transfer>.MapFromJson },
            { "transfer_reversal", Mapper<TransferReversal>.MapFromJson },
        };
    }
}

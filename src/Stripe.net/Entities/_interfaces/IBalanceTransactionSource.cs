namespace Stripe
{
    /// <summary>
    /// Resources that implement this interface can appear as sources in balance transactions.
    /// <para>Possible concrete classes:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="ApplicationFee" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="ApplicationFeeRefund" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Charge" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Dispute" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Issuing.Authorization" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Issuing.Transaction" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Payout" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Refund" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Topup" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Transfer" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="TransferReversal" /></description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IBalanceTransactionSource : IStripeEntity, IHasId, IHasObject
    {
    }
}

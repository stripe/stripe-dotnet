namespace Stripe
{
#if NET6_0_OR_GREATER
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Resources that implement this interface can be used as external accounts, i.e. they can
    /// be attached to a Stripe account to receive payouts.
    /// <para>Possible concrete classes:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="BankAccount" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Card" /></description>
    /// </item>
    /// </list>
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJStripeObjectConverter))]
#endif
    public interface IExternalAccount : IStripeEntity, IHasId, IHasObject
    {
        Account Account { get; }

        string AccountId { get; }
    }
}

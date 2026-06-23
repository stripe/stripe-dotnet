namespace Stripe
{
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

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
    [STJS.JsonConverter(typeof(STJStripeObjectConverter))]
    public interface IExternalAccount : IStripeEntity, IHasId, IHasObject
    {
        Account Account { get; }

        string AccountId { get; }
    }
}

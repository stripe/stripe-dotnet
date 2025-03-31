namespace Stripe
{
#if NET6_0_OR_GREATER
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Resources that implement this interface can be used as payment sources when creating
    /// charges.
    /// <para>Possible concrete classes:</para>
    /// <list type="bullet">
    /// <item>
    /// <description><see cref="Account" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="BankAccount" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Card" /></description>
    /// </item>
    /// <item>
    /// <description><see cref="Source" /></description>
    /// </item>
    /// </list>
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJStripeObjectConverter))]
#endif
    public interface IPaymentSource : IStripeEntity, IHasId, IHasObject
    {
    }
}

namespace Stripe
{
    public interface IStripeTokenService
    {
        StripeToken Create(StripeTokenCreateOptions createOptions);
        StripeToken Get(string tokenId);
    }
}
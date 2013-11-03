namespace Stripe
{
    public interface IStripeOAuthTokenService
    {
        StripeOAuthToken Create(StripeOAuthTokenCreateOptions createOptions);
    }
}
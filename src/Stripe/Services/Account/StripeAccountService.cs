namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null, string stripeAccountId = null) : base(apiKey, stripeAccountId) { }

        public virtual StripeAccount Get()
        {
            var response = Requestor.GetString(Urls.Account, ApiKey, StripeAccountId);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
    }
}
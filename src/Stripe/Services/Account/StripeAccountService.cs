namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null) : base(apiKey) { }

        public virtual StripeAccount Get(StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var response = Requestor.GetString(Urls.Account, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
    }
}
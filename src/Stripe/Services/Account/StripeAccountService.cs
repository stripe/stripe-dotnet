namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null) : base(apiKey) { }

        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.Accounts, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Get(StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var response = Requestor.GetString(Urls.Account, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }
    }
}
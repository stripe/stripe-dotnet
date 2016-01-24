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

        public virtual StripeAccount Get(string accountId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

    }
}
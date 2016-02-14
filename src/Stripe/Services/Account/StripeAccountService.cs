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

        public virtual StripeAccount Get(string accountId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Update(string accountId, StripeAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual void Delete(string accountId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Accounts, accountId);
            url = this.ApplyAllParameters(null, url, false);

            Requestor.Delete(url, requestOptions);
        }
    }
}
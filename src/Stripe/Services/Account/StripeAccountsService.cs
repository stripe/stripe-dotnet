namespace Stripe
{
    public class StripeAccountsService : StripeService
    {
        public StripeAccountsService(string apiKey = null) : base(apiKey) { }

        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var postData = this.ApplyAllParameters(createOptions, "", false);

            //remove the ?
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostData(Urls.Accounts, postData, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Get(string id, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.SpecificAccount, id);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        public virtual StripeAccount Update(string id, StripeAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var postData = this.ApplyAllParameters(updateOptions, "", false);

            //remove the ?
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostData(string.Format(Urls.SpecificAccount, id), postData, requestOptions);

            return Mapper<StripeAccount>.MapFromJson(response);
        }

        private static string RemoveQuestionMark(string source)
        {
            int index = source.IndexOf("?");
            string clean = (index < 0)
                ? source
                : source.Remove(index, "?".Length);

            return clean;
        }
    }
}

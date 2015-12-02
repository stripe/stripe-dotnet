using System.Collections.Generic;

namespace Stripe
{
    public class StripeAccountService : StripeService
    {
        public StripeAccountService(string apiKey = null) : base(apiKey) { }

        public virtual StripeAccount Create(StripeAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            //var url = this.ApplyAllParameters(createOptions, Urls.Accounts, false);
            //var response = Requestor.PostString(url, requestOptions);

            var postData = this.ApplyAllParameters(createOptions, "", false);
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostData(Urls.ManagedAccount, postData, requestOptions);

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

        public virtual IEnumerable<StripeAccount> List(StripeAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(listOptions, Urls.Accounts, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeAccount>.MapCollectionFromJson(response);
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
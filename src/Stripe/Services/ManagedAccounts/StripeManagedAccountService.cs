using System.Collections.Generic;

namespace Stripe
{
    public class StripeManagedAccountService : StripeService
    {
        public StripeManagedAccountService(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultSource { get; set; }

        public virtual StripeManagedAccount Create(StripeManagedAccountCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            //var url = this.ApplyAllParameters(createOptions, Urls.Accounts, false);
            //var response = Requestor.PostString(url, requestOptions);

            var postData = this.ApplyAllParameters(createOptions, "", false);
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostData(Urls.Accounts, postData, requestOptions);

            return Mapper<StripeManagedAccount>.MapFromJson(response);
        }

        public virtual StripeManagedAccount Get(string accountId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.ManagedAccount, accountId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeManagedAccount>.MapFromJson(response);
        }

        public virtual StripeManagedAccount Update(string accountId, StripeManagedAccountUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            //url = this.ApplyAllParameters(updateOptions, url, false);
            //var response = Requestor.PostString(url, requestOptions);

            var url = string.Format(Urls.ManagedAccount, accountId);

            var postData = this.ApplyAllParameters(updateOptions, "", false);
            postData = RemoveQuestionMark(postData);

            var response = Requestor.PostData(url, postData, requestOptions);

            return Mapper<StripeManagedAccount>.MapFromJson(response);
        }

        public virtual void Delete(string accountId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format(Urls.ManagedAccount, accountId);

            Requestor.Delete(url, requestOptions);
        }

        public virtual IEnumerable<StripeManagedAccount> List(StripeManagedAccountListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(listOptions, Urls.Accounts, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeManagedAccount>.MapCollectionFromJson(response);
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

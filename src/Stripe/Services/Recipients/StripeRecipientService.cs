using System.Collections.Generic;

namespace Stripe
{
    public class StripeRecipientService : StripeService
    {
        public StripeRecipientService(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultCard { get; set; }

        public virtual StripeRecipient Create(StripeRecipientCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = this.ApplyAllParameters(createOptions, Urls.Recipients, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }

        public virtual StripeRecipient Get(string recipientId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }

        public virtual StripeRecipient Update(string recipientId, StripeRecipientUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }

        public virtual void Delete(string recipientId, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);

            Requestor.Delete(url, requestOptions);
        }

        public virtual IEnumerable<StripeRecipient> List(StripeRecipientListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = Urls.Recipients;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeRecipient>.MapCollectionFromJson(response);
        }
    }
}

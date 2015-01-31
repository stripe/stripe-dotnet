using System.Collections.Generic;

namespace Stripe
{
    public class StripeRecipientService : StripeService
    {
        public StripeRecipientService(string apiKey = null) : base(apiKey) { }

        public bool ExpandDefaultCard { get; set; }

        public virtual StripeRecipient Create(StripeRecipientCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Recipients, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }

        public virtual StripeRecipient Get(string recipientId)
        {
            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }

        public virtual StripeRecipient Update(string recipientId, StripeRecipientUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }

        public virtual void Delete(string recipientId)
        {
            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual IEnumerable<StripeRecipient> List(StripeRecipientListOptions listOptions = null)
        {
            var url = Urls.Recipients;
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeRecipient>.MapCollectionFromJson(response);
        }
    }
}

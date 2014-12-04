using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

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

#if NET40
        public virtual async Task<StripeRecipient> CreateAsync(StripeRecipientCreateOptions createOptions)
        {
            var url = this.ApplyAllParameters(createOptions, Urls.Recipients, false);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }
#endif

        public virtual StripeRecipient Get(string recipientId)
        {
            var url = FormatGetUrl(recipientId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeRecipient> GetAsync(string recipientId)
        {
            var url = FormatGetUrl(recipientId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }
#endif

        public virtual StripeRecipient Update(string recipientId, StripeRecipientUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(recipientId, updateOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeRecipient> UpdateAsync(string recipientId, StripeRecipientUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(recipientId, updateOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeRecipient>.MapFromJson(response);
        }
#endif
        
        public virtual void Delete(string recipientId)
        {
            var url = FormatDeleteUrl(recipientId);

            Requestor.Delete(url, ApiKey);
        }

#if NET40
        public virtual async Task DeleteAsync(string recipientId)
        {
            var url = FormatDeleteUrl(recipientId);

            await Requestor.DeleteAsync(url, ApiKey);
        }
#endif

        public virtual IEnumerable<StripeRecipient> List(StripeRecipientListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeRecipient>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeRecipient>> ListAsync(StripeRecipientListOptions listOptions = null)
        {
            var url = FormatListUrl(listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeRecipient>.MapCollectionFromJson(response);
        }
#endif

        private string FormatListUrl(StripeRecipientListOptions listOptions)
        {
            var url = Urls.Recipients;
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private string FormatGetUrl(string recipientId)
        {
            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatUpdateUrl(string recipientId, StripeRecipientUpdateOptions updateOptions)
        {
            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
            url = this.ApplyAllParameters(updateOptions, url, false);
            return url;
        }

        private static string FormatDeleteUrl(string recipientId)
        {
            var url = string.Format("{0}/{1}", Urls.Recipients, recipientId);
            return url;
        }
    }
}

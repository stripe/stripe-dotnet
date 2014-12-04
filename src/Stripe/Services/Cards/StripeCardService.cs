using System.Collections.Generic;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    public class StripeCardService : StripeService
    {
        public StripeCardService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandRecipient { get; set; }

        public virtual StripeCard Create(string customerId, StripeCardCreateOptions createOptions)
        {
            var url = FormatCreateUrl(customerId, createOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCard> CreateAsync(string customerId, StripeCardCreateOptions createOptions)
        {
            var url = FormatCreateUrl(customerId, createOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }
#endif

        public virtual StripeCard Get(string customerId, string cardId)
        {
            var url = FormatGetUrl(customerId, cardId);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCard> GetAsync(string customerId, string cardId)
        {
            var url = FormatGetUrl(customerId, cardId);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }
#endif

        public virtual StripeCard Update(string customerId, string cardId, StripeCardUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(customerId, cardId, updateOptions);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

#if NET40
        public virtual async Task<StripeCard> UpdateAsync(string customerId, string cardId, StripeCardUpdateOptions updateOptions)
        {
            var url = FormatUpdateUrl(customerId, cardId, updateOptions);

            var response = await Requestor.PostStringAsync(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }
#endif

        public virtual void Delete(string customerId, string cardId)
        {
            var url = FormatDeleteUrl(customerId, cardId);

            Requestor.Delete(url, ApiKey);
        }

#if NET40
        public virtual async Task DeleteAsync(string customerId, string cardId)
        {
            var url = FormatDeleteUrl(customerId, cardId);

            await Requestor.DeleteAsync(url, ApiKey);
        }
#endif

        public virtual IEnumerable<StripeCard> List(string customerId, StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(customerId, listOptions);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapCollectionFromJson(response);
        }

#if NET40
        public virtual async Task<IEnumerable<StripeCard>> ListAsync(string customerId, StripeListOptions listOptions = null)
        {
            var url = FormatListUrl(customerId, listOptions);

            var response = await Requestor.GetStringAsync(url, ApiKey);

            return Mapper<StripeCard>.MapCollectionFromJson(response);
        }
#endif

        private string FormatListUrl(string customerId, StripeListOptions listOptions)
        {
            var url = string.Format(Urls.Cards, customerId);
            url = this.ApplyAllParameters(listOptions, url, true);
            return url;
        }

        private string FormatCreateUrl(string customerId, StripeCardCreateOptions createOptions)
        {
            var url = string.Format(Urls.Cards, customerId);
            url = this.ApplyAllParameters(createOptions, url, false);
            return url;
        }

        private string FormatGetUrl(string customerId, string cardId)
        {
            var customerUrl = string.Format(Urls.Cards, customerId);
            var url = string.Format("{0}/{1}", customerUrl, cardId);
            url = this.ApplyAllParameters(null, url, false);
            return url;
        }

        private string FormatUpdateUrl(string customerId, string cardId, StripeCardUpdateOptions updateOptions)
        {
            var customerUrl = string.Format(Urls.Cards, customerId);
            var url = string.Format("{0}/{1}", customerUrl, cardId);
            url = this.ApplyAllParameters(updateOptions, url, false);
            return url;
        }

        private static string FormatDeleteUrl(string customerId, string cardId)
        {
            var customerUrl = string.Format(Urls.Cards, customerId);
            var url = string.Format("{0}/{1}", customerUrl, cardId);
            return url;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeCardService : StripeService
    {
        public StripeCardService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandRecipient { get; set; }

        public virtual StripeCard Create(string customerId, StripeCardCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerId, false);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCard Create(string recipientId, StripeCreditCardOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(recipientId, true);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCard Get(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual StripeCard Update(string customerOrRecipientId, string cardId, StripeCardUpdateOptions updateOptions, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.PostString(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual void Delete(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            Requestor.Delete(url, SetupRequestOptions(requestOptions));
        }

        public virtual IEnumerable<StripeCard> List(string customerOrRecipientId, StripeListOptions listOptions = null, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient);

            return Mapper<StripeCard>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions))
            );
        }

#if !PORTABLE
        public virtual async Task<StripeCard> CreateAsync(string customerId, StripeCardCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerId, false);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeCard> CreateAsync(string recipientId, StripeCreditCardOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(recipientId, true);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(createOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeCard> GetAsync(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeCard> UpdateAsync(string customerOrRecipientId, string cardId, StripeCardUpdateOptions updateOptions, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.PostStringAsync(this.ApplyAllParameters(updateOptions, url, false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async void DeleteAsync(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            await Requestor.DeleteAsync(url, SetupRequestOptions(requestOptions));
        }

        public virtual async Task<IEnumerable<StripeCard>> ListAsync(string customerOrRecipientId, StripeListOptions listOptions = null, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            var url = SetupUrl(customerOrRecipientId, isRecipient);

            return Mapper<StripeCard>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, url, true),
                SetupRequestOptions(requestOptions))
            );
        }
#endif

        private string SetupUrl(string customerOrRecipientId, bool isRecipient, string cardId = null)
        {
            var urlParams = string.Format(Urls.CustomerCards, customerOrRecipientId);

            if (isRecipient)
                urlParams = string.Format(Urls.RecipientCards, customerOrRecipientId);

            if (!String.IsNullOrEmpty(cardId))
                return string.Format("{0}/{1}", urlParams, cardId);

            return urlParams;
        }
    }
}

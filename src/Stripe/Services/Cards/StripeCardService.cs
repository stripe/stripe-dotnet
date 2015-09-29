using System;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeCardService : StripeService
    {
        public StripeCardService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandRecipient { get; set; }

        public virtual StripeCard Create(string customerId, StripeCardCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = SetupUrl(customerId, false);
            url = this.ApplyAllParameters(createOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard Create(string recipientId, StripeCreditCardOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = SetupUrl(recipientId, true);
            url = this.ApplyAllParameters(createOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard Get(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard Update(string customerOrRecipientId, string cardId, StripeCardUpdateOptions updateOptions, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, requestOptions);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual void Delete(string customerOrRecipientId, string cardId, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = SetupUrl(customerOrRecipientId, isRecipient, cardId);

            Requestor.Delete(url, requestOptions);
        }

        public virtual IEnumerable<StripeCard> List(string customerOrRecipientId, StripeListOptions listOptions = null, bool isRecipient = false, StripeRequestOptions requestOptions = null)
        {
            requestOptions = SetupRequestOptions(requestOptions);

            var url = SetupUrl(customerOrRecipientId, isRecipient);
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, requestOptions);

            return Mapper<StripeCard>.MapCollectionFromJson(response);
        }

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
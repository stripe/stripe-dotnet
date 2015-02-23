using System.Collections.Generic;

namespace Stripe
{
    public class StripeCardService : StripeService
    {
        public StripeCardService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandRecipient { get; set; }

        public virtual StripeCard Create(string stripeId, StripeCardCreateOptions createOptions, bool isRecipient = false)
        {
            var url = SetUpUrl(stripeId, isRecipient);

            url = this.ApplyAllParameters(createOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard Get(string stripeId, string cardId, bool isRecipient = false)
        {
            var url = SetUpUrl(stripeId, isRecipient, cardId);

            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard Update(string stripeId, string cardId, StripeCardUpdateOptions updateOptions, bool isRecipient = false)
        {
            var url = SetUpUrl(stripeId, isRecipient, cardId);

            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual void Delete(string stripeId, string cardId, bool isRecipient = false)
        {
            var url = SetUpUrl(stripeId, isRecipient, cardId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual IEnumerable<StripeCard> List(string stripeId, StripeListOptions listOptions = null, bool isRecipient = false)
        {
            var url = SetUpUrl(stripeId, isRecipient);

            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapCollectionFromJson(response);
        }

        #region Helper Method
        private string SetUpUrl(string stripeId, bool isRecipient, string cardId = null)
        {
            var urlParams = string.Format(Urls.CustomerCards, stripeId);

            if (isRecipient)
            {
                urlParams = string.Format(Urls.RecipientCards, stripeId);
            }

            if (!string.IsNullOrWhiteSpace(cardId))
            {
                return string.Format("{0}/{1}", urlParams, cardId);
            }

            return urlParams;
        }
        #endregion
    }
}
using System.Collections.Generic;

namespace Stripe
{
    public class StripeCardService : StripeService
    {
        public StripeCardService(string apiKey = null) : base(apiKey) { }

        public bool ExpandCustomer { get; set; }
        public bool ExpandRecipient { get; set; }

        public virtual StripeCard CreateCustomerCard(string customerId, StripeCardCreateOptions createOptions)
        {
            var url = string.Format(Urls.CustomerCards, customerId);
            url = this.ApplyAllParameters(createOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard CreateRecipientCard(string recipientId, StripeCardCreateOptions createOptions)
        {
            var url = string.Format(Urls.RecipientCards, recipientId);
            url = this.ApplyAllParameters(createOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard GetCustomerCard(string customerId, string cardId)
        {
            var customerUrl = string.Format(Urls.CustomerCards, customerId);
            var url = string.Format("{0}/{1}", customerUrl, cardId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard GetRecipientCard(string recipient, string cardId)
        {
            var recipientUrl = string.Format(Urls.RecipientCards, recipient);
            var url = string.Format("{0}/{1}", recipientUrl, cardId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard UpdateCustomerCard(string customerId, string cardId, StripeCardUpdateOptions updateOptions)
        {
            var customerUrl = string.Format(Urls.CustomerCards, customerId);
            var url = string.Format("{0}/{1}", customerUrl, cardId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard UpdateRecipientCard(string recipientId, string cardId, StripeCardUpdateOptions updateOptions)
        {
            var recipientUrl = string.Format(Urls.RecipientCards, recipientId);
            var url = string.Format("{0}/{1}", recipientUrl, cardId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual void DeleteCustomerCard(string customerId, string cardId)
        {
            var customerUrl = string.Format(Urls.CustomerCards, customerId);
            var url = string.Format("{0}/{1}", customerUrl, cardId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual void DeleteRecipientCard(string recipientId, string cardId)
        {
            var recipientUrl = string.Format(Urls.RecipientCards, recipientId);
            var url = string.Format("{0}/{1}", recipientUrl, cardId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual IEnumerable<StripeCard> ListCustomerCards(string customerId, StripeListOptions listOptions = null)
        {
            var url = string.Format(Urls.CustomerCards, customerId);
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapCollectionFromJson(response);
        }

        public virtual IEnumerable<StripeCard> ListRecipientCards(string recipientId, StripeListOptions listOptions = null)
        {
            var url = string.Format(Urls.RecipientCards, recipientId);
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapCollectionFromJson(response);
        }
    }
}
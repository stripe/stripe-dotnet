using System.Collections.Generic;

namespace Stripe
{
    public class StripeCardService : StripeService
    {
        public StripeCardService(string apiKey = null) : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }
        public bool ExpandRecipient { get; set; }

        public virtual StripeCard Create(string ownerId, StripeCardCreateOptions createOptions,
            bool isCustomerCard = true)
        {
            var url = string.Format(isCustomerCard ? Urls.CardsCustomers : Urls.CardsRecipients, ownerId);

            url = this.ApplyAllParameters(createOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard Get(string ownerId, string cardId, bool isCustomerCard = true)
        {
            var customerUrl = CardsUrl(ownerId, isCustomerCard);
            var url = string.Format("{0}/{1}", customerUrl, cardId);
            url = this.ApplyAllParameters(null, url, false);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual StripeCard Update(string ownerId, string cardId, StripeCardUpdateOptions updateOptions,
            bool isCustomerCard = true)
        {
            var customerUrl = CardsUrl(ownerId, isCustomerCard);
            var url = string.Format("{0}/{1}", customerUrl, cardId);
            url = this.ApplyAllParameters(updateOptions, url, false);

            var response = Requestor.PostString(url, ApiKey);

            return Mapper<StripeCard>.MapFromJson(response);
        }

        public virtual void Delete(string ownerId, string cardId, bool isCustomerCard = true)
        {
            var customerUrl = CardsUrl(ownerId, isCustomerCard);
            var url = string.Format("{0}/{1}", customerUrl, cardId);

            Requestor.Delete(url, ApiKey);
        }

        public virtual IEnumerable<StripeCard> List(string ownerId, StripeListOptions listOptions = null,
            bool isCustomerCard = true)
        {
            var url = CardsUrl(ownerId, isCustomerCard);
            url = this.ApplyAllParameters(listOptions, url, true);

            var response = Requestor.GetString(url, ApiKey);

            return Mapper<StripeCard>.MapCollectionFromJson(response);
        }

        private static string CardsUrl(string ownerId, bool isCustomerCard)
        {
            return string.Format(isCustomerCard ? Urls.CardsCustomers : Urls.CardsRecipients, ownerId);
        }
    }
}
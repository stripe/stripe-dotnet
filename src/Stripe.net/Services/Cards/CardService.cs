namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CardService : StripeService
    {
        public CardService()
            : base(null)
        {
        }

        public CardService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public bool ExpandRecipient { get; set; }

        public virtual Card Create(string customerId, CardCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId);

            return Mapper<Card>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Card Get(string customerId, string cardId, RequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<Card>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Card Update(string customerId, string cardId, CardUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<Card>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Card Delete(string customerId, string cardId, RequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<Card>.MapFromJson(
                Requestor.Delete(url, this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Card> List(string customerId, CardListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId);

            if (listOptions == null)
            {
                listOptions = new CardListOptions();
            }

            return Mapper<StripeList<Card>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Card> CreateAsync(string customerId, CardCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId);

            return Mapper<Card>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Card> GetAsync(string customerId, string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<Card>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Card> UpdateAsync(string customerId, string cardId, CardUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<Card>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Card> DeleteAsync(string customerId, string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<Card>.MapFromJson(
                await Requestor.DeleteAsync(
                    url,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Card>> ListAsync(string customerId, CardListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId);

            if (listOptions == null)
            {
                listOptions = new CardListOptions();
            }

            return Mapper<StripeList<Card>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        private string SetupUrl(string customerId, string cardId = null)
        {
            var urlParams = string.Format(Urls.CustomerSources, customerId);

            if (!string.IsNullOrEmpty(cardId))
            {
                return string.Format("{0}/{1}", urlParams, cardId);
            }

            return urlParams;
        }
    }
}

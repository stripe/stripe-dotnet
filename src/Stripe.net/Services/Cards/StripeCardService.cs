namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeCardService : StripeService
    {
        public StripeCardService()
            : base(null)
        {
        }

        public StripeCardService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandCustomer { get; set; }

        public bool ExpandRecipient { get; set; }

        public virtual StripeCard Create(string customerId, StripeCardCreateOptions createOptions, StripeRequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCard Get(string customerId, string cardId, StripeRequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeCard Update(string customerId, string cardId, StripeCardUpdateOptions updateOptions, StripeRequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<StripeCard>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeDeleted Delete(string customerId, string cardId, StripeRequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<StripeDeleted>.MapFromJson(
                Requestor.Delete(url, this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeCard> List(string customerId, StripeCardListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            var url = this.SetupUrl(customerId);

            if (listOptions == null)
            {
                listOptions = new StripeCardListOptions();
            }

            return Mapper<StripeList<StripeCard>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, url, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeCard> CreateAsync(string customerId, StripeCardCreateOptions createOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCard> GetAsync(string customerId, string cardId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeCard> UpdateAsync(string customerId, string cardId, StripeCardUpdateOptions updateOptions, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<StripeCard>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, url, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeDeleted> DeleteAsync(string customerId, string cardId, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId, cardId);

            return Mapper<StripeDeleted>.MapFromJson(
                await Requestor.DeleteAsync(
                    url,
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeCard>> ListAsync(string customerId, StripeCardListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = this.SetupUrl(customerId);

            if (listOptions == null)
            {
                listOptions = new StripeCardListOptions();
            }

            return Mapper<StripeList<StripeCard>>.MapFromJson(
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

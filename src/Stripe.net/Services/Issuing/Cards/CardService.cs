namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CardService : StripeService,
        ICreatable<Card, CardCreateOptions>,
        IListable<Card, CardListOptions>,
        IRetrievable<Card>,
        IUpdatable<Card, CardUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/cards";

        public CardService()
            : base(null)
        {
        }

        public CardService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Card Create(CardCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Card>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual CardDetails Details(string cardId, RequestOptions requestOptions = null)
        {
            return Mapper<CardDetails>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{cardId}/details", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Card Update(string cardId, CardUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Card>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{cardId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Card Get(string cardId, RequestOptions requestOptions = null)
        {
            return Mapper<Card>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{cardId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Card> List(CardListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Card>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Card> CreateAsync(CardCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Card>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<CardDetails> DetailsAsync(string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<CardDetails>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{cardId}/details", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Card> UpdateAsync(string cardId, CardUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Card>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{cardId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Card> GetAsync(string cardId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Card>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{cardId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Card>> ListAsync(CardListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Card>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CardholderService : StripeService,
        ICreatable<Cardholder, CardholderCreateOptions>,
        IListable<Cardholder, CardholderListOptions>,
        IRetrievable<Cardholder>,
        IUpdatable<Cardholder, CardholderUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/issuing/cardholders";

        public CardholderService()
            : base(null)
        {
        }

        public CardholderService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual Cardholder Create(CardholderCreateOptions createOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Cardholder>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Cardholder Update(string cardholderId, CardholderUpdateOptions updateOptions, RequestOptions requestOptions = null)
        {
            return Mapper<Cardholder>.MapFromJson(
                Requestor.PostString(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{cardholderId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual Cardholder Get(string cardholderId, RequestOptions requestOptions = null)
        {
            return Mapper<Cardholder>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{classUrl}/{cardholderId}", false),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<Cardholder> List(CardholderListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<Cardholder>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<Cardholder> CreateAsync(CardholderCreateOptions createOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Cardholder>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(createOptions, classUrl, false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Cardholder> UpdateAsync(string cardholderId, CardholderUpdateOptions updateOptions, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Cardholder>.MapFromJson(
                await Requestor.PostStringAsync(
                    this.ApplyAllParameters(updateOptions, $"{classUrl}/{cardholderId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<Cardholder> GetAsync(string cardholderId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<Cardholder>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{classUrl}/{cardholderId}", false),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<Cardholder>> ListAsync(CardholderListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<Cardholder>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, classUrl, true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

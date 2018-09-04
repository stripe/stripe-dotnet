namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ExchangeRateService : StripeService,
        IListable<ExchangeRate, ExchangeRateListOptions>,
        IRetrievable<ExchangeRate>
    {
        public ExchangeRateService()
            : base(null)
        {
        }

        public ExchangeRateService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual ExchangeRate Get(string currency, RequestOptions requestOptions = null)
        {
            return Mapper<ExchangeRate>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.ExchangeRates}/{currency}"),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<ExchangeRate> List(ExchangeRateListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<ExchangeRate>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.ExchangeRates}", true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<ExchangeRate> GetAsync(string currency, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<ExchangeRate>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.ExchangeRates}/{currency}"),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<ExchangeRate>> ListAsync(ExchangeRateListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<ExchangeRate>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.ExchangeRates}", true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

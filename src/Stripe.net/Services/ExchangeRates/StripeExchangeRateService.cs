namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeExchangeRateService : StripeService
    {
        public StripeExchangeRateService()
            : base(null)
        {
        }

        public StripeExchangeRateService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual StripeExchangeRate Get(string currency, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeExchangeRate>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.ExchangeRates}/{currency}"),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<StripeExchangeRate> List(StripeExchangeRateListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeExchangeRate>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.ExchangeRates}", true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<StripeExchangeRate> GetAsync(string currency, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeExchangeRate>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.ExchangeRates}/{currency}"),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<StripeExchangeRate>> ListAsync(StripeExchangeRateListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeExchangeRate>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.ExchangeRates}", true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

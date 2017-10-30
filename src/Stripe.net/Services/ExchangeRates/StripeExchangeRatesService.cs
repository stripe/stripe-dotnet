using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeExchangeRatesService : StripeService
    {
        public StripeExchangeRatesService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual StripeExchangeRates Get(string currency, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeExchangeRates>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.ExchangeRates}/{currency}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual StripeList<StripeExchangeRates> List(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<StripeExchangeRates>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.ExchangeRates}", true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }



        //Async
        public virtual async Task<StripeExchangeRates> GetAsync(string currency, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeExchangeRates>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.ExchangeRates}/{currency}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        public virtual async Task<StripeList<StripeExchangeRates>> ListAsync(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<StripeExchangeRates>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.ExchangeRates}", true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }
    }
}

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Stripe.Infrastructure;

namespace Stripe
{
    public class CountrySpecService : StripeService
    {
        public CountrySpecService(string apiKey = null) : base(apiKey) { }



        //Sync
        public virtual CountrySpec Get(string country, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual StripeList<CountrySpec> List(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeList<CountrySpec>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }



        //Async
        public virtual async Task<CountrySpec> GetAsync(string country, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<CountrySpec>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}"),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }

        public virtual async Task<StripeList<CountrySpec>> ListAsync(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<CountrySpec>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                    SetupRequestOptions(requestOptions),
                    cancellationToken
                )
            );
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class CountrySpecService : StripeService
    {
        public CountrySpecService(string apiKey = null) : base(apiKey) { }

        public virtual CountrySpec Get(string country, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual IEnumerable<CountrySpec> List(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapCollectionFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual async Task<CountrySpec> GetAsync(string country, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}"),
                    SetupRequestOptions(requestOptions)
                )
            );
        }

        public virtual async Task<IEnumerable<CountrySpec>> ListAsync(StripeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapCollectionFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                    SetupRequestOptions(requestOptions)
                )
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeCountrySpecService : StripeService
    {
        public StripeCountrySpecService(string apiKey = null) : base(apiKey) { }

        public virtual CountrySpec Get(string country, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<CountrySpec> List(StripeChargeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<CountrySpec> GetAsync(string country, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<CountrySpec>> ListAsync(StripeChargeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                SetupRequestOptions(requestOptions))
            );
        }
    }
}

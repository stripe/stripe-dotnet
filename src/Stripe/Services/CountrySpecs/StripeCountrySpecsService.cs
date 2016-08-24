using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stripe
{
    public class StripeCountrySpecsService : StripeService
    {
        public StripeCountrySpecsService(string apiKey = null) : base(apiKey) { }

        public virtual StripeCountrySpec Get(string country, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCountrySpec>.MapFromJson(
                Requestor.GetString(this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual IEnumerable<StripeCountrySpec> List(StripeChargeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCountrySpec>.MapCollectionFromJson(
                Requestor.GetString(this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<StripeCountrySpec> GetAsync(string country, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCountrySpec>.MapFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}", false),
                SetupRequestOptions(requestOptions))
            );
        }

        public virtual async Task<IEnumerable<StripeCountrySpec>> ListAsync(StripeChargeListOptions listOptions = null, StripeRequestOptions requestOptions = null)
        {
            return Mapper<StripeCountrySpec>.MapCollectionFromJson(
                await Requestor.GetStringAsync(this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                SetupRequestOptions(requestOptions))
            );
        }
    }
}

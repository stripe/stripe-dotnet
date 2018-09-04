namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class CountrySpecService : StripeService,
        IListable<CountrySpec, CountrySpecListOptions>,
        IRetrievable<CountrySpec>
    {
        public CountrySpecService()
            : base(null)
        {
        }

        public CountrySpecService(string apiKey)
            : base(apiKey)
        {
        }

        public virtual CountrySpec Get(string country, RequestOptions requestOptions = null)
        {
            return Mapper<CountrySpec>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}"),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual StripeList<CountrySpec> List(CountrySpecListOptions listOptions = null, RequestOptions requestOptions = null)
        {
            return Mapper<StripeList<CountrySpec>>.MapFromJson(
                Requestor.GetString(
                    this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                    this.SetupRequestOptions(requestOptions)));
        }

        public virtual async Task<CountrySpec> GetAsync(string country, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<CountrySpec>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(null, $"{Urls.CountrySpecs}/{country}"),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }

        public virtual async Task<StripeList<CountrySpec>> ListAsync(CountrySpecListOptions listOptions = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Mapper<StripeList<CountrySpec>>.MapFromJson(
                await Requestor.GetStringAsync(
                    this.ApplyAllParameters(listOptions, $"{Urls.CountrySpecs}", true),
                    this.SetupRequestOptions(requestOptions),
                    cancellationToken).ConfigureAwait(false));
        }
    }
}

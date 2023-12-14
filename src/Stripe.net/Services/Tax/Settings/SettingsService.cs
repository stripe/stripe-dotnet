// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SettingsService : Service<Settings>,
        ISingletonRetrievable<Settings>
    {
        public SettingsService()
            : base(null)
        {
        }

        public SettingsService(IStripeClient client)
            : base(client)
        {
        }

        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        public override string BasePath => "/v1/tax/settings";

        public virtual Settings Get(RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(HttpMethod.Get, $"/v1/tax/settings", null, requestOptions);
        }

        public virtual Task<Settings> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(HttpMethod.Get, $"/v1/tax/settings", null, requestOptions, cancellationToken);
        }

        public virtual Settings Get(SettingsGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(HttpMethod.Get, $"/v1/tax/settings", options, requestOptions);
        }

        public virtual Task<Settings> GetAsync(SettingsGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(HttpMethod.Get, $"/v1/tax/settings", options, requestOptions, cancellationToken);
        }

        public virtual Settings Update(SettingsUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(HttpMethod.Post, $"/v1/tax/settings", options, requestOptions);
        }

        public virtual Task<Settings> UpdateAsync(SettingsUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(HttpMethod.Post, $"/v1/tax/settings", options, requestOptions, cancellationToken);
        }
    }
}

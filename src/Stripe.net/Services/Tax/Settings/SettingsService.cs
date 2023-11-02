// File generated from our OpenAPI spec
namespace Stripe.Tax
{
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

        public override string BasePath => "/v1/tax/settings";

        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        public virtual Settings Get(RequestOptions requestOptions = null)
        {
            return this.GetEntity(null, null, requestOptions);
        }

        public virtual Task<Settings> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(null, null, requestOptions, cancellationToken);
        }

        public virtual Settings Update(SettingsUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(null, options, requestOptions);
        }

        public virtual Task<Settings> UpdateAsync(SettingsUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(null, options, requestOptions, cancellationToken);
        }
    }
}

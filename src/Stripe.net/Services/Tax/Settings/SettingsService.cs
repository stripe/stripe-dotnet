// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SettingsService : Service<Settings>,
        ISingletonRetrievable<Settings>
    {
        public SettingsService()
        {
        }

        public SettingsService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/tax/settings";

        [Obsolete("This member is deprecated and will be removed in a future release")]
        protected override string InstanceUrl(string id)
        {
            return this.ClassUrl();
        }

        /// <summary>
        /// <p>Retrieves Tax <c>Settings</c> for a merchant.</p>.
        /// </summary>
        public virtual Settings Get(RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(HttpMethod.Get, $"/v1/tax/settings", null, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves Tax <c>Settings</c> for a merchant.</p>.
        /// </summary>
        public virtual Task<Settings> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(HttpMethod.Get, $"/v1/tax/settings", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves Tax <c>Settings</c> for a merchant.</p>.
        /// </summary>
        public virtual Settings Get(SettingsGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(HttpMethod.Get, $"/v1/tax/settings", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves Tax <c>Settings</c> for a merchant.</p>.
        /// </summary>
        public virtual Task<Settings> GetAsync(SettingsGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(HttpMethod.Get, $"/v1/tax/settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates Tax <c>Settings</c> parameters used in tax calculations. All parameters are
        /// editable but none can be removed once set.</p>.
        /// </summary>
        public virtual Settings Update(SettingsUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Settings>(HttpMethod.Post, $"/v1/tax/settings", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates Tax <c>Settings</c> parameters used in tax calculations. All parameters are
        /// editable but none can be removed once set.</p>.
        /// </summary>
        public virtual Task<Settings> UpdateAsync(SettingsUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Settings>(HttpMethod.Post, $"/v1/tax/settings", options, requestOptions, cancellationToken);
        }
    }
}

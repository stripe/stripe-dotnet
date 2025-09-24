// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BalanceSettingsService : Service,
        ISingletonRetrievable<BalanceSettings>
    {
        public BalanceSettingsService()
        {
        }

        internal BalanceSettingsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public BalanceSettingsService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves balance settings for a given connected account. Related guide: <a
        /// href="https://stripe.com/connect/authentication">Making API calls for connected
        /// accounts</a></p>.
        /// </summary>
        public virtual BalanceSettings Get(RequestOptions requestOptions = null)
        {
            return this.Request<BalanceSettings>(BaseAddress.Api, HttpMethod.Get, $"/v1/balance_settings", null, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves balance settings for a given connected account. Related guide: <a
        /// href="https://stripe.com/connect/authentication">Making API calls for connected
        /// accounts</a></p>.
        /// </summary>
        public virtual Task<BalanceSettings> GetAsync(RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BalanceSettings>(BaseAddress.Api, HttpMethod.Get, $"/v1/balance_settings", null, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves balance settings for a given connected account. Related guide: <a
        /// href="https://stripe.com/connect/authentication">Making API calls for connected
        /// accounts</a></p>.
        /// </summary>
        public virtual BalanceSettings Get(BalanceSettingsGetOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BalanceSettings>(BaseAddress.Api, HttpMethod.Get, $"/v1/balance_settings", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves balance settings for a given connected account. Related guide: <a
        /// href="https://stripe.com/connect/authentication">Making API calls for connected
        /// accounts</a></p>.
        /// </summary>
        public virtual Task<BalanceSettings> GetAsync(BalanceSettingsGetOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BalanceSettings>(BaseAddress.Api, HttpMethod.Get, $"/v1/balance_settings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates balance settings for a given connected account. Related guide: <a
        /// href="https://stripe.com/connect/authentication">Making API calls for connected
        /// accounts</a></p>.
        /// </summary>
        public virtual BalanceSettings Update(BalanceSettingsUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BalanceSettings>(BaseAddress.Api, HttpMethod.Post, $"/v1/balance_settings", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates balance settings for a given connected account. Related guide: <a
        /// href="https://stripe.com/connect/authentication">Making API calls for connected
        /// accounts</a></p>.
        /// </summary>
        public virtual Task<BalanceSettings> UpdateAsync(BalanceSettingsUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BalanceSettings>(BaseAddress.Api, HttpMethod.Post, $"/v1/balance_settings", options, requestOptions, cancellationToken);
        }
    }
}

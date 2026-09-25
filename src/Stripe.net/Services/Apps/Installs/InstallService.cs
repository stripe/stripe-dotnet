// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InstallService : Service,
        ICreatable<Install, InstallCreateOptions>,
        IListable<Install, InstallListOptions>,
        IRetrievable<Install, InstallGetOptions>,
        IUpdatable<Install, InstallUpdateOptions>
    {
        public InstallService()
        {
        }

        internal InstallService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public InstallService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates an app install. An account installs its own private app with its own key;
        /// public and testing installs are made from the Dashboard. An app developer or embedding
        /// platform acting on a connected account through <c>Stripe-Account</c> installs or
        /// reinstalls its app there. Creating an install for a private app that is already
        /// installed at the channel’s current version with nothing pending returns the existing
        /// install.</p>.
        /// </summary>
        public virtual Install Create(InstallCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Install>(BaseAddress.Api, HttpMethod.Post, $"/v1/apps/installs", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates an app install. An account installs its own private app with its own key;
        /// public and testing installs are made from the Dashboard. An app developer or embedding
        /// platform acting on a connected account through <c>Stripe-Account</c> installs or
        /// reinstalls its app there. Creating an install for a private app that is already
        /// installed at the channel’s current version with nothing pending returns the existing
        /// install.</p>.
        /// </summary>
        public virtual Task<Install> CreateAsync(InstallCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Install>(BaseAddress.Api, HttpMethod.Post, $"/v1/apps/installs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves an app install. The installing account, the app’s developer (with the keys
        /// of the account that owns the app or of the app’s managed sandbox), and the embedding
        /// platform that created the install can retrieve it.</p>.
        /// </summary>
        public virtual Install Get(string id, InstallGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Install>(BaseAddress.Api, HttpMethod.Get, $"/v1/apps/installs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves an app install. The installing account, the app’s developer (with the keys
        /// of the account that owns the app or of the app’s managed sandbox), and the embedding
        /// platform that created the install can retrieve it.</p>.
        /// </summary>
        public virtual Task<Install> GetAsync(string id, InstallGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Install>(BaseAddress.Api, HttpMethod.Get, $"/v1/apps/installs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of app installs. An app developer or embedding platform filtering by
        /// its own app sees the installs across the accounts that installed it; other callers see
        /// the installs on their own account. The key selects the environment: a live key lists
        /// live installs, a sandbox API key lists the installs on that sandbox, and the key of an
        /// app’s managed sandbox filtering by <c>app</c> lists that app’s installs across every
        /// sandbox. For existing accounts that still use legacy test mode, a test mode key lists
        /// legacy test mode installs.</p>.
        /// </summary>
        public virtual StripeList<Install> List(InstallListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Install>>(BaseAddress.Api, HttpMethod.Get, $"/v1/apps/installs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of app installs. An app developer or embedding platform filtering by
        /// its own app sees the installs across the accounts that installed it; other callers see
        /// the installs on their own account. The key selects the environment: a live key lists
        /// live installs, a sandbox API key lists the installs on that sandbox, and the key of an
        /// app’s managed sandbox filtering by <c>app</c> lists that app’s installs across every
        /// sandbox. For existing accounts that still use legacy test mode, a test mode key lists
        /// legacy test mode installs.</p>.
        /// </summary>
        public virtual Task<StripeList<Install>> ListAsync(InstallListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Install>>(BaseAddress.Api, HttpMethod.Get, $"/v1/apps/installs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of app installs. An app developer or embedding platform filtering by
        /// its own app sees the installs across the accounts that installed it; other callers see
        /// the installs on their own account. The key selects the environment: a live key lists
        /// live installs, a sandbox API key lists the installs on that sandbox, and the key of an
        /// app’s managed sandbox filtering by <c>app</c> lists that app’s installs across every
        /// sandbox. For existing accounts that still use legacy test mode, a test mode key lists
        /// legacy test mode installs.</p>.
        /// </summary>
        public virtual IEnumerable<Install> ListAutoPaging(InstallListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Install>($"/v1/apps/installs", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of app installs. An app developer or embedding platform filtering by
        /// its own app sees the installs across the accounts that installed it; other callers see
        /// the installs on their own account. The key selects the environment: a live key lists
        /// live installs, a sandbox API key lists the installs on that sandbox, and the key of an
        /// app’s managed sandbox filtering by <c>app</c> lists that app’s installs across every
        /// sandbox. For existing accounts that still use legacy test mode, a test mode key lists
        /// legacy test mode installs.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Install> ListAutoPagingAsync(InstallListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Install>($"/v1/apps/installs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Uninstalls an app from the account that installed it.</p>.
        /// </summary>
        public virtual Install Uninstall(string id, InstallUninstallOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Install>(BaseAddress.Api, HttpMethod.Post, $"/v1/apps/installs/{WebUtility.UrlEncode(id)}/uninstall", options, requestOptions);
        }

        /// <summary>
        /// <p>Uninstalls an app from the account that installed it.</p>.
        /// </summary>
        public virtual Task<Install> UninstallAsync(string id, InstallUninstallOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Install>(BaseAddress.Api, HttpMethod.Post, $"/v1/apps/installs/{WebUtility.UrlEncode(id)}/uninstall", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Reauthorizes an app install. The installer grants the permissions, content security
        /// policy entries, and endpoints that the latest published version of the app requests. An
        /// account reauthorizes its own installs on any channel with its own key; app developers
        /// and embedding platforms reauthorize installs on connected accounts through
        /// <c>Stripe-Account</c>. For private apps, install a new version from the Dashboard to
        /// grant its permissions.</p>.
        /// </summary>
        public virtual Install Update(string id, InstallUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Install>(BaseAddress.Api, HttpMethod.Post, $"/v1/apps/installs/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Reauthorizes an app install. The installer grants the permissions, content security
        /// policy entries, and endpoints that the latest published version of the app requests. An
        /// account reauthorizes its own installs on any channel with its own key; app developers
        /// and embedding platforms reauthorize installs on connected accounts through
        /// <c>Stripe-Account</c>. For private apps, install a new version from the Dashboard to
        /// grant its permissions.</p>.
        /// </summary>
        public virtual Task<Install> UpdateAsync(string id, InstallUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Install>(BaseAddress.Api, HttpMethod.Post, $"/v1/apps/installs/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

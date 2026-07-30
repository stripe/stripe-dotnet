// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountActivityService : Service
    {
        internal AccountActivityService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal AccountActivityService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Creates a new account activity to report account registration, login, or evaluation
        /// follow-up activity.
        /// </summary>
        public virtual AccountActivity Create(AccountActivityCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<AccountActivity>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/account_activity", options, requestOptions);
        }

        /// <summary>
        /// Creates a new account activity to report account registration, login, or evaluation
        /// follow-up activity.
        /// </summary>
        public virtual Task<AccountActivity> CreateAsync(AccountActivityCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountActivity>(BaseAddress.Api, HttpMethod.Post, $"/v2/signals/account_activity", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Deletes an AccountActivity by its ID.
        /// </summary>
        public virtual V2.DeletedObject Delete(string id, AccountActivityDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/signals/account_activity/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Deletes an AccountActivity by its ID.
        /// </summary>
        public virtual Task<V2.DeletedObject> DeleteAsync(string id, AccountActivityDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.DeletedObject>(BaseAddress.Api, HttpMethod.Delete, $"/v2/signals/account_activity/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves an AccountActivity by its ID.
        /// </summary>
        public virtual AccountActivity Get(string id, AccountActivityGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AccountActivity>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/account_activity/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an AccountActivity by its ID.
        /// </summary>
        public virtual Task<AccountActivity> GetAsync(string id, AccountActivityGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountActivity>(BaseAddress.Api, HttpMethod.Get, $"/v2/signals/account_activity/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

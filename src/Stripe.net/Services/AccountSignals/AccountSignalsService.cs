// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AccountSignalsService : Service
    {
        public AccountSignalsService()
        {
        }

        internal AccountSignalsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AccountSignalsService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves the account’s Signal objects</p>.
        /// </summary>
        public virtual AccountSignals Get(string parentId, AccountSignalsGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<AccountSignals>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/signals", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the account’s Signal objects</p>.
        /// </summary>
        public virtual Task<AccountSignals> GetAsync(string parentId, AccountSignalsGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<AccountSignals>(BaseAddress.Api, HttpMethod.Get, $"/v1/accounts/{WebUtility.UrlEncode(parentId)}/signals", options, requestOptions, cancellationToken);
        }
    }
}

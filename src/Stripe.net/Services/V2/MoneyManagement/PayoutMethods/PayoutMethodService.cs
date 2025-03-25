// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PayoutMethodService : Service
    {
        internal PayoutMethodService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PayoutMethodService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Archive a PayoutMethod object. Archived objects cannot be used as payout methods and
        /// will not appear in the payout method list.
        /// </summary>
        public virtual PayoutMethod Archive(string id, PayoutMethodArchiveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/archive", options, requestOptions);
        }

        /// <summary>
        /// Archive a PayoutMethod object. Archived objects cannot be used as payout methods and
        /// will not appear in the payout method list.
        /// </summary>
        public virtual Task<PayoutMethod> ArchiveAsync(string id, PayoutMethodArchiveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/archive", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a PayoutMethod object.
        /// </summary>
        public virtual PayoutMethod Get(string id, PayoutMethodGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutMethod>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a PayoutMethod object.
        /// </summary>
        public virtual Task<PayoutMethod> GetAsync(string id, PayoutMethodGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutMethod>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List objects that adhere to the PayoutMethod interface.
        /// </summary>
        public virtual V2.StripeList<PayoutMethod> List(PayoutMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<PayoutMethod>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_methods", options, requestOptions);
        }

        /// <summary>
        /// List objects that adhere to the PayoutMethod interface.
        /// </summary>
        public virtual Task<V2.StripeList<PayoutMethod>> ListAsync(PayoutMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<PayoutMethod>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/payout_methods", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// List objects that adhere to the PayoutMethod interface.
        /// </summary>
        public virtual IEnumerable<PayoutMethod> ListAutoPaging(PayoutMethodListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<PayoutMethod>($"/v2/money_management/payout_methods", options, requestOptions);
        }

        /// <summary>
        /// List objects that adhere to the PayoutMethod interface.
        /// </summary>
        public virtual IAsyncEnumerable<PayoutMethod> ListAutoPagingAsync(PayoutMethodListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<PayoutMethod>($"/v2/money_management/payout_methods", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Unarchive an PayoutMethod object.
        /// </summary>
        public virtual PayoutMethod Unarchive(string id, PayoutMethodUnarchiveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/unarchive", options, requestOptions);
        }

        /// <summary>
        /// Unarchive an PayoutMethod object.
        /// </summary>
        public virtual Task<PayoutMethod> UnarchiveAsync(string id, PayoutMethodUnarchiveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/unarchive", options, requestOptions, cancellationToken);
        }
    }
}

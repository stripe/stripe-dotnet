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
        /// Archive a <c>PayoutMethod</c>. Archiving prevents the Payout Method from being used for
        /// outbound payments or transfers and omits it from normal list results. To restore list
        /// visibility, use the <a
        /// href="https://docs.stripe.com/api/v2/money-management/payout-methods/unarchive">unarchive
        /// endpoint</a>.
        /// </summary>
        public virtual PayoutMethod Archive(string id, PayoutMethodArchiveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/archive", options, requestOptions);
        }

        /// <summary>
        /// Archive a <c>PayoutMethod</c>. Archiving prevents the Payout Method from being used for
        /// outbound payments or transfers and omits it from normal list results. To restore list
        /// visibility, use the <a
        /// href="https://docs.stripe.com/api/v2/money-management/payout-methods/unarchive">unarchive
        /// endpoint</a>.
        /// </summary>
        public virtual Task<PayoutMethod> ArchiveAsync(string id, PayoutMethodArchiveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/archive", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Disable a <c>PayoutMethod</c>. Disabling temporarily prevents the Payout Method from
        /// being used for outbound payments or transfers while keeping it in normal list results.
        /// To re-enable it, complete setup again by <a
        /// href="https://docs.stripe.com/api/v2/money-management/outbound-setup-intents/create">creating
        /// an Outbound Setup Intent</a>.
        /// </summary>
        public virtual PayoutMethod Disable(string id, PayoutMethodDisableOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/disable", options, requestOptions);
        }

        /// <summary>
        /// Disable a <c>PayoutMethod</c>. Disabling temporarily prevents the Payout Method from
        /// being used for outbound payments or transfers while keeping it in normal list results.
        /// To re-enable it, complete setup again by <a
        /// href="https://docs.stripe.com/api/v2/money-management/outbound-setup-intents/create">creating
        /// an Outbound Setup Intent</a>.
        /// </summary>
        public virtual Task<PayoutMethod> DisableAsync(string id, PayoutMethodDisableOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/disable", options, requestOptions, cancellationToken);
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
        /// Unarchive a <c>PayoutMethod</c>. Unarchiving restores the Payout Method to normal list
        /// results and clears only its archived state. It doesn't guarantee that the Payout Method
        /// can be used.
        /// </summary>
        public virtual PayoutMethod Unarchive(string id, PayoutMethodUnarchiveOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/unarchive", options, requestOptions);
        }

        /// <summary>
        /// Unarchive a <c>PayoutMethod</c>. Unarchiving restores the Payout Method to normal list
        /// results and clears only its archived state. It doesn't guarantee that the Payout Method
        /// can be used.
        /// </summary>
        public virtual Task<PayoutMethod> UnarchiveAsync(string id, PayoutMethodUnarchiveOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<PayoutMethod>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/payout_methods/{WebUtility.UrlEncode(id)}/unarchive", options, requestOptions, cancellationToken);
        }
    }
}

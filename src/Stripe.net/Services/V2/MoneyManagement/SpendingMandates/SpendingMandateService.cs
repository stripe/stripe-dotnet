// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class SpendingMandateService : Service
    {
        internal SpendingMandateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal SpendingMandateService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancels an active SpendingMandate.
        /// </summary>
        public virtual SpendingMandate Cancel(string id, SpendingMandateCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SpendingMandate>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/spending_mandates/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels an active SpendingMandate.
        /// </summary>
        public virtual Task<SpendingMandate> CancelAsync(string id, SpendingMandateCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SpendingMandate>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/spending_mandates/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing SpendingMandate.
        /// </summary>
        public virtual SpendingMandate Get(string id, SpendingMandateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<SpendingMandate>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/spending_mandates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing SpendingMandate.
        /// </summary>
        public virtual Task<SpendingMandate> GetAsync(string id, SpendingMandateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<SpendingMandate>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/spending_mandates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of SpendingMandates.
        /// </summary>
        public virtual V2.StripeList<SpendingMandate> List(SpendingMandateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<SpendingMandate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/spending_mandates", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of SpendingMandates.
        /// </summary>
        public virtual Task<V2.StripeList<SpendingMandate>> ListAsync(SpendingMandateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<SpendingMandate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/spending_mandates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of SpendingMandates.
        /// </summary>
        public virtual IEnumerable<SpendingMandate> ListAutoPaging(SpendingMandateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<SpendingMandate>($"/v2/money_management/spending_mandates", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of SpendingMandates.
        /// </summary>
        public virtual IAsyncEnumerable<SpendingMandate> ListAutoPagingAsync(SpendingMandateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<SpendingMandate>($"/v2/money_management/spending_mandates", options, requestOptions, cancellationToken);
        }
    }
}

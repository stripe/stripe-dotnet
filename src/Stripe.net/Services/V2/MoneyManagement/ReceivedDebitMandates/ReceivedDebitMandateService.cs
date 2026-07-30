// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReceivedDebitMandateService : Service
    {
        internal ReceivedDebitMandateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReceivedDebitMandateService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancels an active ReceivedDebitMandate.
        /// </summary>
        public virtual ReceivedDebitMandate Cancel(string id, ReceivedDebitMandateCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReceivedDebitMandate>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/received_debit_mandates/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancels an active ReceivedDebitMandate.
        /// </summary>
        public virtual Task<ReceivedDebitMandate> CancelAsync(string id, ReceivedDebitMandateCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReceivedDebitMandate>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/received_debit_mandates/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of an existing ReceivedDebitMandate.
        /// </summary>
        public virtual ReceivedDebitMandate Get(string id, ReceivedDebitMandateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReceivedDebitMandate>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_debit_mandates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of an existing ReceivedDebitMandate.
        /// </summary>
        public virtual Task<ReceivedDebitMandate> GetAsync(string id, ReceivedDebitMandateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReceivedDebitMandate>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_debit_mandates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of ReceivedDebitMandates.
        /// </summary>
        public virtual V2.StripeList<ReceivedDebitMandate> List(ReceivedDebitMandateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ReceivedDebitMandate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_debit_mandates", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of ReceivedDebitMandates.
        /// </summary>
        public virtual Task<V2.StripeList<ReceivedDebitMandate>> ListAsync(ReceivedDebitMandateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ReceivedDebitMandate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_debit_mandates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns a list of ReceivedDebitMandates.
        /// </summary>
        public virtual IEnumerable<ReceivedDebitMandate> ListAutoPaging(ReceivedDebitMandateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReceivedDebitMandate>($"/v2/money_management/received_debit_mandates", options, requestOptions);
        }

        /// <summary>
        /// Returns a list of ReceivedDebitMandates.
        /// </summary>
        public virtual IAsyncEnumerable<ReceivedDebitMandate> ListAutoPagingAsync(ReceivedDebitMandateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReceivedDebitMandate>($"/v2/money_management/received_debit_mandates", options, requestOptions, cancellationToken);
        }
    }
}

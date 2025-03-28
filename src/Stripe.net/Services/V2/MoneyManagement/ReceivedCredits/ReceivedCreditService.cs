// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReceivedCreditService : Service
    {
        internal ReceivedCreditService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReceivedCreditService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieve a ReceivedCredit by ID.
        /// </summary>
        public virtual ReceivedCredit Get(string id, ReceivedCreditGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReceivedCredit>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_credits/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a ReceivedCredit by ID.
        /// </summary>
        public virtual Task<ReceivedCredit> GetAsync(string id, ReceivedCreditGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReceivedCredit>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_credits/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of ReceivedCredits.
        /// </summary>
        public virtual V2.StripeList<ReceivedCredit> List(ReceivedCreditListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<ReceivedCredit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_credits", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of ReceivedCredits.
        /// </summary>
        public virtual Task<V2.StripeList<ReceivedCredit>> ListAsync(ReceivedCreditListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<ReceivedCredit>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/received_credits", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves a list of ReceivedCredits.
        /// </summary>
        public virtual IEnumerable<ReceivedCredit> ListAutoPaging(ReceivedCreditListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReceivedCredit>($"/v2/money_management/received_credits", options, requestOptions);
        }

        /// <summary>
        /// Retrieves a list of ReceivedCredits.
        /// </summary>
        public virtual IAsyncEnumerable<ReceivedCredit> ListAutoPagingAsync(ReceivedCreditListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReceivedCredit>($"/v2/money_management/received_credits", options, requestOptions, cancellationToken);
        }
    }
}

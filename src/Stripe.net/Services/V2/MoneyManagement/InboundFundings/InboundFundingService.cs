// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InboundFundingService : Service
    {
        internal InboundFundingService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal InboundFundingService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Retrieves an InboundFunding by ID.
        /// </summary>
        public virtual InboundFunding Get(string id, InboundFundingGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InboundFunding>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_fundings/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves an InboundFunding by ID.
        /// </summary>
        public virtual Task<InboundFunding> GetAsync(string id, InboundFundingGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundFunding>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_fundings/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists InboundFundings.
        /// </summary>
        public virtual V2.StripeList<InboundFunding> List(InboundFundingListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<InboundFunding>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_fundings", options, requestOptions);
        }

        /// <summary>
        /// Lists InboundFundings.
        /// </summary>
        public virtual Task<V2.StripeList<InboundFunding>> ListAsync(InboundFundingListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<InboundFunding>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_fundings", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists InboundFundings.
        /// </summary>
        public virtual IEnumerable<InboundFunding> ListAutoPaging(InboundFundingListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InboundFunding>($"/v2/money_management/inbound_fundings", options, requestOptions);
        }

        /// <summary>
        /// Lists InboundFundings.
        /// </summary>
        public virtual IAsyncEnumerable<InboundFunding> ListAutoPagingAsync(InboundFundingListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InboundFunding>($"/v2/money_management/inbound_fundings", options, requestOptions, cancellationToken);
        }
    }
}

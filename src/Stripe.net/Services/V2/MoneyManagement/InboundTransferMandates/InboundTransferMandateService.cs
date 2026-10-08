// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class InboundTransferMandateService : Service
    {
        internal InboundTransferMandateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal InboundTransferMandateService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Cancel a pending or active InboundTransferMandate.
        /// </summary>
        public virtual InboundTransferMandate Cancel(string id, InboundTransferMandateCancelOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransferMandate>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/inbound_transfer_mandates/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions);
        }

        /// <summary>
        /// Cancel a pending or active InboundTransferMandate.
        /// </summary>
        public virtual Task<InboundTransferMandate> CancelAsync(string id, InboundTransferMandateCancelOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransferMandate>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/inbound_transfer_mandates/{WebUtility.UrlEncode(id)}/cancel", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Create an InboundTransferMandate for a v2 credential. If a pending or active mandate
        /// already exists for the same user and credential, that mandate is returned instead of
        /// creating a new one.
        /// </summary>
        public virtual InboundTransferMandate Create(InboundTransferMandateCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransferMandate>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/inbound_transfer_mandates", options, requestOptions);
        }

        /// <summary>
        /// Create an InboundTransferMandate for a v2 credential. If a pending or active mandate
        /// already exists for the same user and credential, that mandate is returned instead of
        /// creating a new one.
        /// </summary>
        public virtual Task<InboundTransferMandate> CreateAsync(InboundTransferMandateCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransferMandate>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/inbound_transfer_mandates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve an InboundTransferMandate by ID.
        /// </summary>
        public virtual InboundTransferMandate Get(string id, InboundTransferMandateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<InboundTransferMandate>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_transfer_mandates/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieve an InboundTransferMandate by ID.
        /// </summary>
        public virtual Task<InboundTransferMandate> GetAsync(string id, InboundTransferMandateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<InboundTransferMandate>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_transfer_mandates/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of InboundTransferMandates for the authenticated compartment.
        /// </summary>
        public virtual V2.StripeList<InboundTransferMandate> List(InboundTransferMandateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<InboundTransferMandate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_transfer_mandates", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a list of InboundTransferMandates for the authenticated compartment.
        /// </summary>
        public virtual Task<V2.StripeList<InboundTransferMandate>> ListAsync(InboundTransferMandateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<InboundTransferMandate>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/inbound_transfer_mandates", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of InboundTransferMandates for the authenticated compartment.
        /// </summary>
        public virtual IEnumerable<InboundTransferMandate> ListAutoPaging(InboundTransferMandateListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<InboundTransferMandate>($"/v2/money_management/inbound_transfer_mandates", options, requestOptions);
        }

        /// <summary>
        /// Retrieve a list of InboundTransferMandates for the authenticated compartment.
        /// </summary>
        public virtual IAsyncEnumerable<InboundTransferMandate> ListAutoPagingAsync(InboundTransferMandateListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<InboundTransferMandate>($"/v2/money_management/inbound_transfer_mandates", options, requestOptions, cancellationToken);
        }
    }
}

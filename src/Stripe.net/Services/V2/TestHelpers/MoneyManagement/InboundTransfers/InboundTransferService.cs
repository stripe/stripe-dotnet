// File generated from our OpenAPI spec
namespace Stripe.V2.TestHelpers.MoneyManagement
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.V2.MoneyManagement;

    public class InboundTransferService : Service
    {
        internal InboundTransferService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal InboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Fails an InboundTransfer for testing purposes in a Sandbox environment.
        /// </summary>
        public virtual V2.MoneyManagement.InboundTransfer Fail(string id, InboundTransferFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/money_management/inbound_transfers/{WebUtility.UrlEncode(id)}/fail", options, requestOptions);
        }

        /// <summary>
        /// Fails an InboundTransfer for testing purposes in a Sandbox environment.
        /// </summary>
        public virtual Task<V2.MoneyManagement.InboundTransfer> FailAsync(string id, InboundTransferFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/money_management/inbound_transfers/{WebUtility.UrlEncode(id)}/fail", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Returns an InboundTransfer for testing purposes in a Sandbox environment.
        /// </summary>
        public virtual V2.MoneyManagement.InboundTransfer Return(string id, InboundTransferReturnOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/money_management/inbound_transfers/{WebUtility.UrlEncode(id)}/return", options, requestOptions);
        }

        /// <summary>
        /// Returns an InboundTransfer for testing purposes in a Sandbox environment.
        /// </summary>
        public virtual Task<V2.MoneyManagement.InboundTransfer> ReturnAsync(string id, InboundTransferReturnOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/money_management/inbound_transfers/{WebUtility.UrlEncode(id)}/return", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Succeeds an InboundTransfer for testing purposes in a Sandbox environment.
        /// </summary>
        public virtual V2.MoneyManagement.InboundTransfer Succeed(string id, InboundTransferSucceedOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/money_management/inbound_transfers/{WebUtility.UrlEncode(id)}/succeed", options, requestOptions);
        }

        /// <summary>
        /// Succeeds an InboundTransfer for testing purposes in a Sandbox environment.
        /// </summary>
        public virtual Task<V2.MoneyManagement.InboundTransfer> SucceedAsync(string id, InboundTransferSucceedOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v2/test_helpers/money_management/inbound_transfers/{WebUtility.UrlEncode(id)}/succeed", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class OperationService : Service
    {
        internal OperationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OperationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Resolves an address to its tax precision level.
        /// </summary>
        public virtual OperationsResolveAddressResult ResolveAddress(OperationResolveAddressOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<OperationsResolveAddressResult>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/operations/resolve_address", options, requestOptions);
        }

        /// <summary>
        /// Resolves an address to its tax precision level.
        /// </summary>
        public virtual Task<OperationsResolveAddressResult> ResolveAddressAsync(OperationResolveAddressOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<OperationsResolveAddressResult>(BaseAddress.Api, HttpMethod.Post, $"/v2/tax/operations/resolve_address", options, requestOptions, cancellationToken);
        }
    }
}

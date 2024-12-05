// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class AssociationService : Service<Association>
    {
        public AssociationService()
        {
        }

        internal AssociationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public AssociationService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Finds a tax association object by PaymentIntent id.</p>.
        /// </summary>
        public virtual Association Find(AssociationFindOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Association>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/associations/find", options, requestOptions);
        }

        /// <summary>
        /// <p>Finds a tax association object by PaymentIntent id.</p>.
        /// </summary>
        public virtual Task<Association> FindAsync(AssociationFindOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Association>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/associations/find", options, requestOptions, cancellationToken);
        }
    }
}

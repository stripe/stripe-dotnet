// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreditReversalService : Service<CreditReversal>,
        ICreatable<CreditReversal, CreditReversalCreateOptions>,
        IListable<CreditReversal, CreditReversalListOptions>,
        IRetrievable<CreditReversal, CreditReversalGetOptions>
    {
        public CreditReversalService()
        {
        }

        public CreditReversalService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/credit_reversals";

        /// <summary>
        /// <p>Reverses a ReceivedCredit and creates a CreditReversal object.</p>.
        /// </summary>
        public virtual CreditReversal Create(CreditReversalCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CreditReversal>(HttpMethod.Post, $"/v1/treasury/credit_reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>Reverses a ReceivedCredit and creates a CreditReversal object.</p>.
        /// </summary>
        public virtual Task<CreditReversal> CreateAsync(CreditReversalCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditReversal>(HttpMethod.Post, $"/v1/treasury/credit_reversals", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing CreditReversal by passing the unique
        /// CreditReversal ID from either the CreditReversal creation request or CreditReversal
        /// list</p>.
        /// </summary>
        public virtual CreditReversal Get(string id, CreditReversalGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CreditReversal>(HttpMethod.Get, $"/v1/treasury/credit_reversals/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing CreditReversal by passing the unique
        /// CreditReversal ID from either the CreditReversal creation request or CreditReversal
        /// list</p>.
        /// </summary>
        public virtual Task<CreditReversal> GetAsync(string id, CreditReversalGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CreditReversal>(HttpMethod.Get, $"/v1/treasury/credit_reversals/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of CreditReversals.</p>.
        /// </summary>
        public virtual StripeList<CreditReversal> List(CreditReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CreditReversal>>(HttpMethod.Get, $"/v1/treasury/credit_reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of CreditReversals.</p>.
        /// </summary>
        public virtual Task<StripeList<CreditReversal>> ListAsync(CreditReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CreditReversal>>(HttpMethod.Get, $"/v1/treasury/credit_reversals", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of CreditReversals.</p>.
        /// </summary>
        public virtual IEnumerable<CreditReversal> ListAutoPaging(CreditReversalListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CreditReversal>($"/v1/treasury/credit_reversals", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of CreditReversals.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<CreditReversal> ListAutoPagingAsync(CreditReversalListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CreditReversal>($"/v1/treasury/credit_reversals", options, requestOptions, cancellationToken);
        }
    }
}

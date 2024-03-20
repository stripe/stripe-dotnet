// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class ReceivedDebitService : Service<Stripe.Treasury.ReceivedDebit>
    {
        public ReceivedDebitService()
        {
        }

        public ReceivedDebitService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/test_helpers/treasury/received_debits";

        /// <summary>
        /// <p>Use this endpoint to simulate a test mode ReceivedDebit initiated by a third party.
        /// In live mode, you can’t directly create ReceivedDebits initiated by third parties.</p>.
        /// </summary>
        public virtual Stripe.Treasury.ReceivedDebit Create(ReceivedDebitCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.ReceivedDebit>(HttpMethod.Post, $"/v1/test_helpers/treasury/received_debits", options, requestOptions);
        }

        /// <summary>
        /// <p>Use this endpoint to simulate a test mode ReceivedDebit initiated by a third party.
        /// In live mode, you can’t directly create ReceivedDebits initiated by third parties.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.ReceivedDebit> CreateAsync(ReceivedDebitCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.ReceivedDebit>(HttpMethod.Post, $"/v1/test_helpers/treasury/received_debits", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class ReceivedCreditService : Service
    {
        public ReceivedCreditService()
        {
        }

        internal ReceivedCreditService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReceivedCreditService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Use this endpoint to simulate a test mode ReceivedCredit initiated by a third party.
        /// In live mode, you can’t directly create ReceivedCredits initiated by third parties.</p>.
        /// </summary>
        public virtual Stripe.Treasury.ReceivedCredit Create(ReceivedCreditCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.ReceivedCredit>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/received_credits", options, requestOptions);
        }

        /// <summary>
        /// <p>Use this endpoint to simulate a test mode ReceivedCredit initiated by a third party.
        /// In live mode, you can’t directly create ReceivedCredits initiated by third parties.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.ReceivedCredit> CreateAsync(ReceivedCreditCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.ReceivedCredit>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/received_credits", options, requestOptions, cancellationToken);
        }
    }
}

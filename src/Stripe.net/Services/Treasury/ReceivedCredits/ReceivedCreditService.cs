// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReceivedCreditService : Service<ReceivedCredit>,
        IListable<ReceivedCredit, ReceivedCreditListOptions>,
        IRetrievable<ReceivedCredit, ReceivedCreditGetOptions>
    {
        public ReceivedCreditService()
        {
        }

        public ReceivedCreditService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/treasury/received_credits";

        /// <summary>
        /// <p>Retrieves the details of an existing ReceivedCredit by passing the unique
        /// ReceivedCredit ID from the ReceivedCredit list.</p>.
        /// </summary>
        public virtual ReceivedCredit Get(string id, ReceivedCreditGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ReceivedCredit>(HttpMethod.Get, $"/v1/treasury/received_credits/{id}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves the details of an existing ReceivedCredit by passing the unique
        /// ReceivedCredit ID from the ReceivedCredit list.</p>.
        /// </summary>
        public virtual Task<ReceivedCredit> GetAsync(string id, ReceivedCreditGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ReceivedCredit>(HttpMethod.Get, $"/v1/treasury/received_credits/{id}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReceivedCredits.</p>.
        /// </summary>
        public virtual StripeList<ReceivedCredit> List(ReceivedCreditListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ReceivedCredit>>(HttpMethod.Get, $"/v1/treasury/received_credits", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReceivedCredits.</p>.
        /// </summary>
        public virtual Task<StripeList<ReceivedCredit>> ListAsync(ReceivedCreditListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ReceivedCredit>>(HttpMethod.Get, $"/v1/treasury/received_credits", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of ReceivedCredits.</p>.
        /// </summary>
        public virtual IEnumerable<ReceivedCredit> ListAutoPaging(ReceivedCreditListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ReceivedCredit>($"/v1/treasury/received_credits", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of ReceivedCredits.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<ReceivedCredit> ListAutoPagingAsync(ReceivedCreditListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ReceivedCredit>($"/v1/treasury/received_credits", options, requestOptions, cancellationToken);
        }
    }
}

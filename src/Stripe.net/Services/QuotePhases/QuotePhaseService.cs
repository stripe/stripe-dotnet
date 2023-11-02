// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class QuotePhaseService : Service<QuotePhase>,
        IListable<QuotePhase, QuotePhaseListOptions>,
        IRetrievable<QuotePhase, QuotePhaseGetOptions>
    {
        public QuotePhaseService()
            : base(null)
        {
        }

        public QuotePhaseService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/quote_phases";

        public virtual QuotePhase Get(string id, QuotePhaseGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<QuotePhase>(HttpMethod.Get, $"/v1/quote_phases/{id}", options, requestOptions);
        }

        public virtual Task<QuotePhase> GetAsync(string id, QuotePhaseGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<QuotePhase>(HttpMethod.Get, $"/v1/quote_phases/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<QuotePhase> List(QuotePhaseListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<QuotePhase>>(HttpMethod.Get, $"/v1/quote_phases", options, requestOptions);
        }

        public virtual Task<StripeList<QuotePhase>> ListAsync(QuotePhaseListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<QuotePhase>>(HttpMethod.Get, $"/v1/quote_phases", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<QuotePhase> ListAutoPaging(QuotePhaseListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<QuotePhase>($"/v1/quote_phases", options, requestOptions);
        }

        public virtual IAsyncEnumerable<QuotePhase> ListAutoPagingAsync(QuotePhaseListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<QuotePhase>($"/v1/quote_phases", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<LineItem> ListLineItems(string id, QuotePhaseListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quote_phases/{id}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<LineItem>> ListLineItemsAsync(string id, QuotePhaseListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<LineItem>>(HttpMethod.Get, $"/v1/quote_phases/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<LineItem> ListLineItemsAutoPaging(string id, QuotePhaseListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<LineItem>($"/v1/quote_phases/{id}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<LineItem> ListLineItemsAutoPagingAsync(string id, QuotePhaseListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<LineItem>($"/v1/quote_phases/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}

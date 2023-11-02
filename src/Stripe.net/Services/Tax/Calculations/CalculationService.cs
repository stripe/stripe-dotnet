// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CalculationService : Service<Calculation>,
        ICreatable<Calculation, CalculationCreateOptions>
    {
        public CalculationService()
            : base(null)
        {
        }

        public CalculationService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/tax/calculations";

        public virtual Calculation Create(CalculationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Calculation>(HttpMethod.Post, $"/v1/tax/calculations", options, requestOptions);
        }

        public virtual Task<Calculation> CreateAsync(CalculationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Calculation>(HttpMethod.Post, $"/v1/tax/calculations", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<CalculationLineItem> ListLineItems(string id, CalculationListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<CalculationLineItem>>(HttpMethod.Get, $"/v1/tax/calculations/{id}/line_items", options, requestOptions);
        }

        public virtual Task<StripeList<CalculationLineItem>> ListLineItemsAsync(string id, CalculationListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<CalculationLineItem>>(HttpMethod.Get, $"/v1/tax/calculations/{id}/line_items", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<CalculationLineItem> ListLineItemsAutoPaging(string id, CalculationListLineItemsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CalculationLineItem>($"/v1/tax/calculations/{id}/line_items", options, requestOptions);
        }

        public virtual IAsyncEnumerable<CalculationLineItem> ListLineItemsAutoPagingAsync(string id, CalculationListLineItemsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CalculationLineItem>($"/v1/tax/calculations/{id}/line_items", options, requestOptions, cancellationToken);
        }
    }
}

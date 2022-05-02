// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PriceService : Service<Price>,
        ICreatable<Price, PriceCreateOptions>,
        IListable<Price, PriceListOptions>,
        IRetrievable<Price, PriceGetOptions>,
        ISearchable<Price, PriceSearchOptions>,
        IUpdatable<Price, PriceUpdateOptions>
    {
        public PriceService()
            : base(null)
        {
        }

        public PriceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/prices";

        public virtual Price Create(PriceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Price> CreateAsync(PriceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Price Get(string id, PriceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Price> GetAsync(string id, PriceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Price> List(PriceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Price>> ListAsync(PriceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Price> ListAutoPaging(PriceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual IAsyncEnumerable<Price> ListAutoPagingAsync(PriceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }

        public virtual StripeSearchResult<Price> Search(PriceSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeSearchResult<Price>>(HttpMethod.Get, $"{this.InstanceUrl("search")}", options, requestOptions);
        }

        public virtual Task<StripeSearchResult<Price>> SearchAsync(PriceSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeSearchResult<Price>>(HttpMethod.Get, $"{this.InstanceUrl("search")}", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Price> SearchAutoPaging(PriceSearchOptions options = null, RequestOptions requestOptions = null)
        {
            return this.SearchRequestAutoPaging<Price>($"{this.InstanceUrl("search")}", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Price> SearchAutoPagingAsync(PriceSearchOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.SearchRequestAutoPagingAsync<Price>($"{this.InstanceUrl("search")}", options, requestOptions, cancellationToken);
        }

        public virtual Price Update(string id, PriceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Price> UpdateAsync(string id, PriceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}

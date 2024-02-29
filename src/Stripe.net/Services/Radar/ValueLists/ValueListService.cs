// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ValueListService : Service<ValueList>,
        ICreatable<ValueList, ValueListCreateOptions>,
        IDeletable<ValueList, ValueListDeleteOptions>,
        IListable<ValueList, ValueListListOptions>,
        IRetrievable<ValueList, ValueListGetOptions>,
        IUpdatable<ValueList, ValueListUpdateOptions>
    {
        public ValueListService()
            : base(null)
        {
        }

        public ValueListService(IStripeClient client)
            : base(client)
        {
        }

        [Obsolete("This member is deprecated and will be removed in a future release")]
        public override string BasePath => "/v1/radar/value_lists";

        public virtual ValueList Create(ValueListCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ValueList>(HttpMethod.Post, $"/v1/radar/value_lists", options, requestOptions);
        }

        public virtual Task<ValueList> CreateAsync(ValueListCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueList>(HttpMethod.Post, $"/v1/radar/value_lists", options, requestOptions, cancellationToken);
        }

        public virtual ValueList Delete(string id, ValueListDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ValueList>(HttpMethod.Delete, $"/v1/radar/value_lists/{id}", options, requestOptions);
        }

        public virtual Task<ValueList> DeleteAsync(string id, ValueListDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueList>(HttpMethod.Delete, $"/v1/radar/value_lists/{id}", options, requestOptions, cancellationToken);
        }

        public virtual ValueList Get(string id, ValueListGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ValueList>(HttpMethod.Get, $"/v1/radar/value_lists/{id}", options, requestOptions);
        }

        public virtual Task<ValueList> GetAsync(string id, ValueListGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueList>(HttpMethod.Get, $"/v1/radar/value_lists/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ValueList> List(ValueListListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<ValueList>>(HttpMethod.Get, $"/v1/radar/value_lists", options, requestOptions);
        }

        public virtual Task<StripeList<ValueList>> ListAsync(ValueListListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<ValueList>>(HttpMethod.Get, $"/v1/radar/value_lists", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ValueList> ListAutoPaging(ValueListListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<ValueList>($"/v1/radar/value_lists", options, requestOptions);
        }

        public virtual IAsyncEnumerable<ValueList> ListAutoPagingAsync(ValueListListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<ValueList>($"/v1/radar/value_lists", options, requestOptions, cancellationToken);
        }

        public virtual ValueList Update(string id, ValueListUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<ValueList>(HttpMethod.Post, $"/v1/radar/value_lists/{id}", options, requestOptions);
        }

        public virtual Task<ValueList> UpdateAsync(string id, ValueListUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ValueList>(HttpMethod.Post, $"/v1/radar/value_lists/{id}", options, requestOptions, cancellationToken);
        }
    }
}

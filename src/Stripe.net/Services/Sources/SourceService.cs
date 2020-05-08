namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SourceService : Service<Source>,
        ICreatable<Source, SourceCreateOptions>,
        IRetrievable<Source, SourceGetOptions>,
        IUpdatable<Source, SourceUpdateOptions>
    {
        public SourceService()
            : base(null)
        {
        }

        public SourceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/sources";

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual unknown Detach(string id, SourceDetachOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<unknown>(HttpMethod.Delete, /v1/customers/{customer}/sources/{id}, options, requestOptions);
        }

        public virtual Task<unknown> DetachAsync(string id, SourceDetachOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<unknown>(HttpMethod.Delete, /v1/customers/{customer}/sources/{id}, options, requestOptions, cancellationToken);
        }

        public virtual Source Get(string id, SourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Source> GetAsync(string id, SourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual ApmsSourcesSourceTransactionList SourceTransactions(string id, SourceSourceTransactionsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<ApmsSourcesSourceTransactionList>(HttpMethod.Get, $"{this.InstanceUrl(id)}/source_transactions", options, requestOptions);
        }

        public virtual Task<ApmsSourcesSourceTransactionList> SourceTransactionsAsync(string id, SourceSourceTransactionsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<ApmsSourcesSourceTransactionList>(HttpMethod.Get, $"{this.InstanceUrl(id)}/source_transactions", options, requestOptions, cancellationToken);
        }

        public virtual Source Update(string id, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

        public virtual Task<Source> UpdateAsync(string id, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Source Verify(string id, SourceVerifyOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify", options, requestOptions);
        }

        public virtual Task<Source> VerifyAsync(string id, SourceVerifyOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify", options, requestOptions, cancellationToken);
        }
    }
}

namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PayoutService : Service<Payout>,
        ICreatable<Payout, PayoutCreateOptions>,
        IListable<Payout, PayoutListOptions>,
        IRetrievable<Payout, PayoutGetOptions>,
        IUpdatable<Payout, PayoutUpdateOptions>
    {
        public PayoutService()
            : base(null)
        {
        }

        public PayoutService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/payouts";

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandBalanceTransaction { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandDestination { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandFailureBalanceTransaction { get; set; }

        public virtual Payout Cancel(string payoutId, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(payoutId)}/cancel", null, requestOptions);
        }

        public virtual Task<Payout> CancelAsync(string payoutId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(payoutId)}/cancel", null, requestOptions, cancellationToken);
        }

        public virtual Payout Create(PayoutCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Payout> CreateAsync(PayoutCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Payout Get(string payoutId, PayoutGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(payoutId, options, requestOptions);
        }

        public virtual Task<Payout> GetAsync(string payoutId, PayoutGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(payoutId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Payout> List(PayoutListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Payout>> ListAsync(PayoutListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Payout> ListAutoPaging(PayoutListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Payout Update(string payoutId, PayoutUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(payoutId, options, requestOptions);
        }

        public virtual Task<Payout> UpdateAsync(string payoutId, PayoutUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(payoutId, options, requestOptions, cancellationToken);
        }
    }
}

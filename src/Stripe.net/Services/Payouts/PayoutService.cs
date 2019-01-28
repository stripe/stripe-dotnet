namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class PayoutService : Service<Payout>,
        ICreatable<Payout, PayoutCreateOptions>,
        IListable<Payout, PayoutListOptions>,
        IRetrievable<Payout>,
        IUpdatable<Payout, PayoutUpdateOptions>
    {
        public PayoutService()
            : base(null)
        {
        }

        public PayoutService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/payouts";

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandDestination { get; set; }

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

        public virtual Payout Get(string payoutId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(payoutId, null, requestOptions);
        }

        public virtual Task<Payout> GetAsync(string payoutId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(payoutId, null, requestOptions, cancellationToken);
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

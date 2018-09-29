namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class RefundService : Service<Refund>,
        ICreatable<Refund, RefundCreateOptions>,
        IListable<Refund, RefundListOptions>,
        IRetrievable<Refund>,
        IUpdatable<Refund, RefundUpdateOptions>
    {
        private static string classUrl = Urls.BaseUrl + "/refunds";

        public RefundService()
            : base(null)
        {
        }

        public RefundService(string apiKey)
            : base(apiKey)
        {
        }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandCharge { get; set; }

        public bool ExpandFailureBalanceTransaction { get; set; }

        public virtual Refund Create(RefundCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}", requestOptions, options);
        }

        public virtual Refund Get(string refundId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{classUrl}/{refundId}", requestOptions);
        }

        public virtual StripeList<Refund> List(RefundListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{classUrl}", requestOptions, options);
        }

        public virtual Refund Update(string refundId, RefundUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{classUrl}/{refundId}", requestOptions, options);
        }

        public virtual Task<Refund> CreateAsync(RefundCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Refund> GetAsync(string refundId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{classUrl}/{refundId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Refund>> ListAsync(RefundListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{classUrl}", requestOptions, cancellationToken, options);
        }

        public virtual Task<Refund> UpdateAsync(string refundId, RefundUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{classUrl}/{refundId}", requestOptions, cancellationToken, options);
        }
    }
}

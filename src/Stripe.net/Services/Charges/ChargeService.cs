namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ChargeService : Service<Charge>,
        ICreatable<Charge, ChargeCreateOptions>,
        IListable<Charge, ChargeListOptions>,
        IRetrievable<Charge, ChargeGetOptions>,
        IUpdatable<Charge, ChargeUpdateOptions>
    {
        public ChargeService()
            : base(null)
        {
        }

        public ChargeService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/charges";

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandApplication { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandApplicationFee { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandBalanceTransaction { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandCustomer { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandDestination { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandDispute { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandInvoice { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandOnBehalfOf { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandOrder { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandReview { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandSourceTransfer { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandTransfer { get; set; }

        [Obsolete("Use BaseOptions.AddExpand instead.")]
        public bool ExpandBusinessLogo { get; set; }

        public virtual Charge Capture(string chargeId, ChargeCaptureOptions options, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(chargeId)}/capture", options, requestOptions);
        }

        public virtual Task<Charge> CaptureAsync(string chargeId, ChargeCaptureOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(chargeId)}/capture", options, requestOptions, cancellationToken);
        }

        public virtual Charge Create(ChargeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Charge> CreateAsync(ChargeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Charge Get(string chargeId, ChargeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(chargeId, options, requestOptions);
        }

        public virtual Task<Charge> GetAsync(string chargeId, ChargeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(chargeId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Charge> List(ChargeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Charge>> ListAsync(ChargeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Charge> ListAutoPaging(ChargeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Charge Update(string chargeId, ChargeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(chargeId, options, requestOptions);
        }

        public virtual Task<Charge> UpdateAsync(string chargeId, ChargeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.UpdateEntityAsync(chargeId, options, requestOptions, cancellationToken);
        }
    }
}

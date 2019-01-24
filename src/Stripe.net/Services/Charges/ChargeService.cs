namespace Stripe
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class ChargeService : Service<Charge>,
        ICreatable<Charge, ChargeCreateOptions>,
        IListable<Charge, ChargeListOptions>,
        IRetrievable<Charge>,
        IUpdatable<Charge, ChargeUpdateOptions>
    {
        public ChargeService()
            : base(null)
        {
        }

        public ChargeService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/v1/charges";

        public bool ExpandApplication { get; set; }

        public bool ExpandApplicationFee { get; set; }

        public bool ExpandBalanceTransaction { get; set; }

        public bool ExpandCustomer { get; set; }

        public bool ExpandDestination { get; set; }

        public bool ExpandDispute { get; set; }

        public bool ExpandInvoice { get; set; }

        public bool ExpandOnBehalfOf { get; set; }

        public bool ExpandOrder { get; set; }

        public bool ExpandReview { get; set; }

        public bool ExpandSourceTransfer { get; set; }

        public bool ExpandTransfer { get; set; }

        public bool ExpandBusinessLogo { get; set; }

        public virtual Charge Capture(string chargeId, ChargeCaptureOptions options, RequestOptions requestOptions = null)
        {
            return this.PostRequest<Charge>($"{this.InstanceUrl(chargeId)}/capture", options, requestOptions);
        }

        public virtual Task<Charge> CaptureAsync(string chargeId, ChargeCaptureOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostRequestAsync<Charge>($"{this.InstanceUrl(chargeId)}/capture", options, requestOptions, cancellationToken);
        }

        public virtual Charge Create(ChargeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Charge> CreateAsync(ChargeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Charge Get(string chargeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity(chargeId, null, requestOptions);
        }

        public virtual Task<Charge> GetAsync(string chargeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync(chargeId, null, requestOptions, cancellationToken);
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

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

        public virtual Charge Capture(string chargeId, ChargeCaptureOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request(HttpMethod.Post, $"{this.InstanceUrl(chargeId)}/capture", options, requestOptions);
        }

        public virtual Task<Charge> CaptureAsync(string chargeId, ChargeCaptureOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync(HttpMethod.Post, $"{this.InstanceUrl(chargeId)}/capture", options, requestOptions, cancellationToken);
        }

        public virtual Charge Create(ChargeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Charge> CreateAsync(ChargeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Charge Get(string chargeId, ChargeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(chargeId, options, requestOptions);
        }

        public virtual Task<Charge> GetAsync(string chargeId, ChargeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(chargeId, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Charge> List(ChargeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Charge>> ListAsync(ChargeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Charge> ListAutoPaging(ChargeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

#if !NET45
        public virtual IAsyncEnumerable<Charge> ListAutoPagingAsync(ChargeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAutoPagingAsync(options, requestOptions, cancellationToken);
        }
#endif

        public virtual Charge Update(string chargeId, ChargeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(chargeId, options, requestOptions);
        }

        public virtual Task<Charge> UpdateAsync(string chargeId, ChargeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.UpdateEntityAsync(chargeId, options, requestOptions, cancellationToken);
        }
    }
}

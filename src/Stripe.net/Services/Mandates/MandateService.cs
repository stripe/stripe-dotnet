namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;

    public class MandateService : Service<Mandate>,
        IRetrievable<Mandate, MandateGetOptions>
    {
        public MandateService()
            : base(null)
        {
        }

        public MandateService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/mandates";

        public virtual Mandate Get(string id, MandateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<Mandate> GetAsync(string id, MandateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}

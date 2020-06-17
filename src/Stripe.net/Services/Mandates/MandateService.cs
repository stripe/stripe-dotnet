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

        public virtual Mandate Get(string mandateId, MandateGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(mandateId, options, requestOptions);
        }

        public virtual Task<Mandate> GetAsync(string mandateId, MandateGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(mandateId, options, requestOptions, cancellationToken);
        }
    }
}

namespace Stripe
{
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

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
            return this.Post($"{Urls.BaseUrl}/charges/{chargeId}/capture", requestOptions, options);
        }

        public virtual Charge Create(ChargeCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/charges", requestOptions, options);
        }

        public virtual Charge Delete(string chargeId, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity($"{Urls.BaseUrl}/charges/{chargeId}", requestOptions);
        }

        public virtual Charge Get(string chargeId, RequestOptions requestOptions = null)
        {
            return this.GetEntity($"{Urls.BaseUrl}/charges/{chargeId}", requestOptions);
        }

        public virtual StripeList<Charge> List(ChargeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntityList($"{Urls.BaseUrl}/charges", requestOptions, options);
        }

        public virtual Charge Update(string chargeId, ChargeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Post($"{Urls.BaseUrl}/charges/{chargeId}", requestOptions, options);
        }

        public virtual Task<Charge> CaptureAsync(string chargeId, ChargeCaptureOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/charges/{chargeId}/capture", requestOptions, cancellationToken, options);
        }

        public virtual Task<Charge> CreateAsync(ChargeCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/charges", requestOptions, cancellationToken, options);
        }

        public virtual Task<Charge> DeleteAsync(string chargeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.DeleteEntityAsync($"{Urls.BaseUrl}/charges/{chargeId}", requestOptions, cancellationToken);
        }

        public virtual Task<Charge> GetAsync(string chargeId, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityAsync($"{Urls.BaseUrl}/charges/{chargeId}", requestOptions, cancellationToken);
        }

        public virtual Task<StripeList<Charge>> ListAsync(ChargeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.GetEntityListAsync($"{Urls.BaseUrl}/charges", requestOptions, cancellationToken, options);
        }

        public virtual Task<Charge> UpdateAsync(string chargeId, ChargeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.PostAsync($"{Urls.BaseUrl}/charges/{chargeId}", requestOptions, cancellationToken, options);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class CalculationService : Service<Calculation>,
        ICreatable<Calculation, CalculationCreateOptions>,
        IRetrievable<Calculation, CalculationGetOptions>
    {
        private CalculationLineItemService lineItems;

        public CalculationService()
        {
        }

        internal CalculationService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CalculationService(IStripeClient client)
            : base(client)
        {
        }

        public virtual CalculationLineItemService LineItems => this.lineItems ??= new CalculationLineItemService(
            this.Requestor);

        /// <summary>
        /// <p>Calculates tax based on the input and returns a Tax <c>Calculation</c> object.</p>.
        /// </summary>
        public virtual Calculation Create(CalculationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Calculation>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/calculations", options, requestOptions);
        }

        /// <summary>
        /// <p>Calculates tax based on the input and returns a Tax <c>Calculation</c> object.</p>.
        /// </summary>
        public virtual Task<Calculation> CreateAsync(CalculationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Calculation>(BaseAddress.Api, HttpMethod.Post, $"/v1/tax/calculations", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a Tax <c>Calculation</c> object, if the calculation hasn’t expired.</p>.
        /// </summary>
        public virtual Calculation Get(string id, CalculationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Calculation>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a Tax <c>Calculation</c> object, if the calculation hasn’t expired.</p>.
        /// </summary>
        public virtual Task<Calculation> GetAsync(string id, CalculationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Calculation>(BaseAddress.Api, HttpMethod.Get, $"/v1/tax/calculations/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerFundingInstructionsService : ServiceNested<FundingInstructions>
    {
        public CustomerFundingInstructionsService()
        {
        }

        internal CustomerFundingInstructionsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerFundingInstructionsService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieve funding instructions for a customer cash balance. If funding instructions do
        /// not yet exist for the customer, new funding instructions will be created. If funding
        /// instructions have already been created for a given customer, the same funding
        /// instructions will be retrieved. In other words, we will return the same funding
        /// instructions each time.</p>.
        /// </summary>
        public virtual FundingInstructions Create(string parentId, CustomerFundingInstructionsCreateOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<FundingInstructions>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/funding_instructions", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieve funding instructions for a customer cash balance. If funding instructions do
        /// not yet exist for the customer, new funding instructions will be created. If funding
        /// instructions have already been created for a given customer, the same funding
        /// instructions will be retrieved. In other words, we will return the same funding
        /// instructions each time.</p>.
        /// </summary>
        public virtual Task<FundingInstructions> CreateAsync(string parentId, CustomerFundingInstructionsCreateOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<FundingInstructions>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/funding_instructions", options, requestOptions, cancellationToken);
        }
    }
}

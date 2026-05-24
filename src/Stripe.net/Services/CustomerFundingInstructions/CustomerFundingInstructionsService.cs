// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    public class CustomerFundingInstructionsService : Service
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

        /// <summary>
        /// Serializes a CustomerFundingInstructions create request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchCreateFundingInstructions(string customer, CustomerFundingInstructionsCreateOptions options = null, RequestOptions requestOptions = null)
        {
            var requestId = Guid.NewGuid().ToString();
            var stripeVersion = StripeConfiguration.ApiVersion;
            var stripeContext = requestOptions?.StripeContext;

            var requestBody = new Dictionary<string, object>
            {
                { "id", requestId },
                { "path_params", new Dictionary<string, string> { { "customer", customer } } },
                { "params", options },
                { "stripe_version", stripeVersion },
            };
            if (stripeContext != null)
            {
                requestBody["context"] = stripeContext;
            }

            return JsonSerializer.Serialize(requestBody, new JsonSerializerOptions(StripeConfiguration.SerializerOptions) { DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull });
        }
    }
}

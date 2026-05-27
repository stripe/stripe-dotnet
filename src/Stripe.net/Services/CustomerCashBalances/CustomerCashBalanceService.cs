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

    public class CustomerCashBalanceService : Service
    {
        public CustomerCashBalanceService()
        {
        }

        internal CustomerCashBalanceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public CustomerCashBalanceService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Retrieves a customer’s cash balance.</p>.
        /// </summary>
        public virtual CashBalance Get(string parentId, CustomerCashBalanceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CashBalance>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a customer’s cash balance.</p>.
        /// </summary>
        public virtual Task<CashBalance> GetAsync(string parentId, CustomerCashBalanceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CashBalance>(BaseAddress.Api, HttpMethod.Get, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Serializes a CustomerCashBalance update request into a batch job JSONL line.
        /// </summary>
        public virtual string SerializeBatchUpdate(string customer, CustomerCashBalanceUpdateOptions options = null, RequestOptions requestOptions = null)
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

        /// <summary>
        /// <p>Changes the settings on a customer’s cash balance.</p>.
        /// </summary>
        public virtual CashBalance Update(string parentId, CustomerCashBalanceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CashBalance>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance", options, requestOptions);
        }

        /// <summary>
        /// <p>Changes the settings on a customer’s cash balance.</p>.
        /// </summary>
        public virtual Task<CashBalance> UpdateAsync(string parentId, CustomerCashBalanceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CashBalance>(BaseAddress.Api, HttpMethod.Post, $"/v1/customers/{WebUtility.UrlEncode(parentId)}/cash_balance", options, requestOptions, cancellationToken);
        }
    }
}

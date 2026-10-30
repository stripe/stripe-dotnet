// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class CurrencyConversionService : Service
    {
        internal CurrencyConversionService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CurrencyConversionService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Create a new Currency Conversion in a Financial Account or the payments balance.
        /// </summary>
        public virtual CurrencyConversion Create(CurrencyConversionCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<CurrencyConversion>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/currency_conversions", options, requestOptions);
        }

        /// <summary>
        /// Create a new Currency Conversion in a Financial Account or the payments balance.
        /// </summary>
        public virtual Task<CurrencyConversion> CreateAsync(CurrencyConversionCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CurrencyConversion>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/currency_conversions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of a Currency Conversion by its ID.
        /// </summary>
        public virtual CurrencyConversion Get(string id, CurrencyConversionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<CurrencyConversion>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/currency_conversions/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the details of a Currency Conversion by its ID.
        /// </summary>
        public virtual Task<CurrencyConversion> GetAsync(string id, CurrencyConversionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<CurrencyConversion>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/currency_conversions/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists all Currency Conversions that match the provided filters.
        /// </summary>
        public virtual V2.StripeList<CurrencyConversion> List(CurrencyConversionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.StripeList<CurrencyConversion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/currency_conversions", options, requestOptions);
        }

        /// <summary>
        /// Lists all Currency Conversions that match the provided filters.
        /// </summary>
        public virtual Task<V2.StripeList<CurrencyConversion>> ListAsync(CurrencyConversionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.StripeList<CurrencyConversion>>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/currency_conversions", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Lists all Currency Conversions that match the provided filters.
        /// </summary>
        public virtual IEnumerable<CurrencyConversion> ListAutoPaging(CurrencyConversionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<CurrencyConversion>($"/v2/money_management/currency_conversions", options, requestOptions);
        }

        /// <summary>
        /// Lists all Currency Conversions that match the provided filters.
        /// </summary>
        public virtual IAsyncEnumerable<CurrencyConversion> ListAutoPagingAsync(CurrencyConversionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<CurrencyConversion>($"/v2/money_management/currency_conversions", options, requestOptions, cancellationToken);
        }
    }
}

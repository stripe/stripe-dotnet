// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.FinancialAccounts
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class WalletExportService : Service
    {
        internal WalletExportService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal WalletExportService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Exports wallet credentials encrypted to the supplied recipient key. The first successful
        /// request starts one fixed one-hour retrieval window; later requests may use a different
        /// recipient key without extending it.
        /// </summary>
        public virtual V2.MoneyManagement.FinancialAccountWalletExportCredentials ExportCredentials(string id, WalletExportExportCredentialsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.FinancialAccountWalletExportCredentials>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}/wallet_export/export_credentials", options, requestOptions);
        }

        /// <summary>
        /// Exports wallet credentials encrypted to the supplied recipient key. The first successful
        /// request starts one fixed one-hour retrieval window; later requests may use a different
        /// recipient key without extending it.
        /// </summary>
        public virtual Task<V2.MoneyManagement.FinancialAccountWalletExportCredentials> ExportCredentialsAsync(string id, WalletExportExportCredentialsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.FinancialAccountWalletExportCredentials>(BaseAddress.Api, HttpMethod.Post, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}/wallet_export/export_credentials", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// Retrieves the wallet export metadata for a closed FinancialAccount. Credentials are
        /// returned only by the export_credentials action.
        /// </summary>
        public virtual V2.MoneyManagement.FinancialAccountWalletExport Get(string id, WalletExportGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<V2.MoneyManagement.FinancialAccountWalletExport>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}/wallet_export", options, requestOptions);
        }

        /// <summary>
        /// Retrieves the wallet export metadata for a closed FinancialAccount. Credentials are
        /// returned only by the export_credentials action.
        /// </summary>
        public virtual Task<V2.MoneyManagement.FinancialAccountWalletExport> GetAsync(string id, WalletExportGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<V2.MoneyManagement.FinancialAccountWalletExport>(BaseAddress.Api, HttpMethod.Get, $"/v2/money_management/financial_accounts/{WebUtility.UrlEncode(id)}/wallet_export", options, requestOptions, cancellationToken);
        }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class BalanceTransferService : Service,
        ICreatable<BalanceTransfer, BalanceTransferCreateOptions>
    {
        public BalanceTransferService()
        {
        }

        internal BalanceTransferService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public BalanceTransferService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Creates a balance transfer. For Issuing use cases, funds will be debited immediately
        /// from the source balance and credited to the destination balance immediately (if your
        /// account is based in the US) or next-business-day (if your account is based in the EU).
        /// For Segregated Separate Charges and Transfers use cases, funds will be debited
        /// immediately from the source balance and credited immediately to the destination
        /// balance.</p>.
        /// </summary>
        public virtual BalanceTransfer Create(BalanceTransferCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<BalanceTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/balance_transfers", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a balance transfer. For Issuing use cases, funds will be debited immediately
        /// from the source balance and credited to the destination balance immediately (if your
        /// account is based in the US) or next-business-day (if your account is based in the EU).
        /// For Segregated Separate Charges and Transfers use cases, funds will be debited
        /// immediately from the source balance and credited immediately to the destination
        /// balance.</p>.
        /// </summary>
        public virtual Task<BalanceTransfer> CreateAsync(BalanceTransferCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<BalanceTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/balance_transfers", options, requestOptions, cancellationToken);
        }
    }
}

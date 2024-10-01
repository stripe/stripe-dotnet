// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class FinancialConnectionsService : Service
    {
        private FinancialConnections.AccountService accounts;
        private FinancialConnections.SessionService sessions;
        private FinancialConnections.TransactionService transactions;

        internal FinancialConnectionsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal FinancialConnectionsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual FinancialConnections.AccountService Accounts => this.accounts ??= new FinancialConnections.AccountService(
            this.Requestor);

        public virtual FinancialConnections.SessionService Sessions => this.sessions ??= new FinancialConnections.SessionService(
            this.Requestor);

        public virtual FinancialConnections.TransactionService Transactions => this.transactions ??= new FinancialConnections.TransactionService(
            this.Requestor);
    }
}

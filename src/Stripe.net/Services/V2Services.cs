// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class V2Services : Service
    {
        private V2.BillingService billing;
        private V2.CommerceService commerce;
        private V2.CoreService core;
        private V2.DataService data;
        private V2.ExtendService extend;
        private V2.IamService iam;
        private V2.MoneyManagementService moneyManagement;
        private V2.NetworkService network;
        private V2.OrchestratedCommerceService orchestratedCommerce;
        private V2.TestHelperService testHelpers;

        internal V2Services(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal V2Services(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.BillingService Billing => this.billing ??= new V2.BillingService(
            this.Requestor);

        public virtual V2.CommerceService Commerce => this.commerce ??= new V2.CommerceService(
            this.Requestor);

        public virtual V2.CoreService Core => this.core ??= new V2.CoreService(
            this.Requestor);

        public virtual V2.DataService Data => this.data ??= new V2.DataService(
            this.Requestor);

        public virtual V2.ExtendService Extend => this.extend ??= new V2.ExtendService(
            this.Requestor);

        public virtual V2.IamService Iam => this.iam ??= new V2.IamService(
            this.Requestor);

        public virtual V2.MoneyManagementService MoneyManagement => this.moneyManagement ??= new V2.MoneyManagementService(
            this.Requestor);

        public virtual V2.NetworkService Network => this.network ??= new V2.NetworkService(
            this.Requestor);

        public virtual V2.OrchestratedCommerceService OrchestratedCommerce => this.orchestratedCommerce ??= new V2.OrchestratedCommerceService(
            this.Requestor);

        public virtual V2.TestHelperService TestHelpers => this.testHelpers ??= new V2.TestHelperService(
            this.Requestor);
    }
}

// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProvisioningService : Service
    {
        private V2.Provisioning.CatalogService catalog;
        private V2.Provisioning.EligibilityService eligibility;
        private V2.Provisioning.PaymentMethodRequestService paymentMethodRequests;
        private V2.Provisioning.PaymentProfileService paymentProfile;
        private V2.Provisioning.ProjectService projects;
        private V2.Provisioning.ProviderConnectionService providerConnections;
        private V2.Provisioning.ProviderConnectionRequestService providerConnectionRequests;
        private V2.Provisioning.ResourceService resources;

        internal ProvisioningService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ProvisioningService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Provisioning.CatalogService Catalog => this.catalog ??= new V2.Provisioning.CatalogService(
            this.Requestor);

        public virtual V2.Provisioning.EligibilityService Eligibility => this.eligibility ??= new V2.Provisioning.EligibilityService(
            this.Requestor);

        public virtual V2.Provisioning.PaymentMethodRequestService PaymentMethodRequests => this.paymentMethodRequests ??= new V2.Provisioning.PaymentMethodRequestService(
            this.Requestor);

        public virtual V2.Provisioning.PaymentProfileService PaymentProfile => this.paymentProfile ??= new V2.Provisioning.PaymentProfileService(
            this.Requestor);

        public virtual V2.Provisioning.ProjectService Projects => this.projects ??= new V2.Provisioning.ProjectService(
            this.Requestor);

        public virtual V2.Provisioning.ProviderConnectionService ProviderConnections => this.providerConnections ??= new V2.Provisioning.ProviderConnectionService(
            this.Requestor);

        public virtual V2.Provisioning.ProviderConnectionRequestService ProviderConnectionRequests => this.providerConnectionRequests ??= new V2.Provisioning.ProviderConnectionRequestService(
            this.Requestor);

        public virtual V2.Provisioning.ResourceService Resources => this.resources ??= new V2.Provisioning.ResourceService(
            this.Requestor);
    }
}

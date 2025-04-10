// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class PrivacyService : Service
    {
        private Privacy.RedactionJobService redactionJobs;

        internal PrivacyService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal PrivacyService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Privacy.RedactionJobService RedactionJobs => this.redactionJobs ??= new Privacy.RedactionJobService(
            this.Requestor);
    }
}

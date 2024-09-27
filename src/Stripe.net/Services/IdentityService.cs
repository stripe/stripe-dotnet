// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class IdentityService : Service
    {
        private Identity.VerificationReportService verificationReports;
        private Identity.VerificationSessionService verificationSessions;

        internal IdentityService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal IdentityService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Identity.VerificationReportService VerificationReports => this.verificationReports ??= new Identity.VerificationReportService(
            this.Requestor);

        public virtual Identity.VerificationSessionService VerificationSessions => this.verificationSessions ??= new Identity.VerificationSessionService(
            this.Requestor);
    }
}

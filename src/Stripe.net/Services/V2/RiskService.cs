// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class RiskService : Service
    {
        private V2.Risk.InquiryService inquiries;

        internal RiskService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RiskService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Risk.InquiryService Inquiries => this.inquiries ??= new V2.Risk.InquiryService(
            this.Requestor);
    }
}

using System.Web;
using System.IO;

namespace Stripe.Tests
{
    public class event_hooks_handler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }
        
        public void ProcessRequest(HttpContext context)
        {
            var json = new StreamReader(context.Request.InputStream).ReadToEnd();

            var stripeEvent = StripeEventUtility.ParseEvent(json);

            switch (stripeEvent.Type)
            {
                case "charge.refunded":
                    var stripeCharge = Stripe.Mapper<StripeCharge>.MapFromJson(stripeEvent.Data.Object.ToString());
                    break;
                case "charge.dispute.created":
                    var stripeDispute = Stripe.Mapper<StripeDispute>.MapFromJson(stripeEvent.Data.Object.ToString());
                    break;
            }
        }
    }
}
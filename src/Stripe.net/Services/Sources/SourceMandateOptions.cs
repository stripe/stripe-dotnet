namespace Stripe
{
    using System;
    using Stripe.Infrastructure;

    public class SourceMandateOptions : INestedOptions
    {
        [FormProperty("acceptance[date]")]
        public DateTime? MandateAcceptanceDate { get; set; }

        [FormProperty("acceptance[ip]")]
        public string MandateAcceptanceIp { get; set; }

        [FormProperty("acceptance[status]")]
        public string MandateAcceptanceStatus { get; set; }

        [FormProperty("acceptance[user_agent]")]
        public string MandateAcceptanceUserAgent { get; set; }

        [FormProperty("notification_method")]
        public string MandateNotificationMethod { get; set; }
    }
}

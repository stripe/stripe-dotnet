namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class LoginLinkCreateOptions : BaseOptions
    {
        [FormProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}

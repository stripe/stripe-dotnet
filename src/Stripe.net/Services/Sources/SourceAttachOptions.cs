namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class SourceAttachOptions : BaseOptions
    {
        /// <summary>
        /// REQUIRED: The identifier of the source to be attached.
        /// </summary>
        [FormProperty("source")]
        public string Source { get; set; }

        [FormProperty("validate")]
        public bool? Validate { get; set; }
    }
}

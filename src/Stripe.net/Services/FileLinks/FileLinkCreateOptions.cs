namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class FileLinkCreateOptions : FileLinkSharedOptions
    {
        /// <summary>
        /// The ID of the file.
        /// </summary>
        [FormProperty("file")]
        public string FileId { get; set; }
    }
}

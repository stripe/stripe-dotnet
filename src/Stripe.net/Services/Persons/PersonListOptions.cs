namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonListOptions : ListOptions
    {
        [JsonProperty("relationship")]
        public PersonRelationshipListOptions Relationship { get; set; }
    }
}

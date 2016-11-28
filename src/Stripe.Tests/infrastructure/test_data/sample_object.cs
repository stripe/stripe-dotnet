using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe.Tests.test_data
{
    public class sample_object
    {
        public sample_object()
        {
            StringContainingText = "Foo";
            StringWithDifferentName = "Foo";
            Number = 42;
            Metadata = new Dictionary<string, string> {
                { "A", "Value-A" },
                { "B", "Value-B" }
            };
            EqualDateFilter = new StripeDateFilter { EqualTo = DateTime.Parse("2000-01-01") };
            LessThanDateFilter = new StripeDateFilter { LessThan = DateTime.Parse("2000-01-01") };
            ComplexDateFilter = new StripeDateFilter
            {
                LessThan = DateTime.Parse("2100-01-01"),
                GreaterThan = DateTime.Parse("2000-01-01")
            };
        }

        public string StringWithoutAttribute { get; set; }

        [JsonProperty("differentname")]
        public string StringWithDifferentName { get; set; }

        [JsonProperty("stringcontainingtext")]
        public string StringContainingText { get; set; }

        [JsonProperty("stringcontainingnull")]
        public string StringContainingNull { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("nullnumber")]
        public int? NullNumber { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("dateequals")]
        public StripeDateFilter EqualDateFilter { get; set; }

        [JsonProperty("datelessthan")]
        public StripeDateFilter LessThanDateFilter { get; set; }

        [JsonProperty("datecomplex")]
        public StripeDateFilter ComplexDateFilter { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe.Tests.test_data
{
    public class sample_object
    {
        public sample_object()
        {
            StringContainingText = "Foo";
            StringWithDifferentName = "Foo";
            StringWithEncoding = "H=I";
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
            SubObject = new sample_sub_object()
            {
                Pi = "3.1415"
            };
            SubObjectWithConverter = new sample_sub_object_with_custom_converter()
            {
                Value = "Hello"
            };
            NullSubObjectWithConverter = new sample_sub_object_with_custom_converter()
            {
                Value = null
            };
        }

        public string StringWithoutAttribute { get; set; }

        [JsonProperty("differentname")]
        public string StringWithDifferentName { get; set; }

        [JsonProperty("stringcontainingtext")]
        public string StringContainingText { get; set; }

        [JsonProperty("stringcontainingnull")]
        public string StringContainingNull { get; set; }

        [JsonProperty("stringwithencoding")]
        public string StringWithEncoding { get; set; }

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

        [JsonProperty("subobject")]
        public object SubObject { get; set; }

        [JsonProperty("subobjectwithconverter")]
        public object SubObjectWithConverter { get; set; }

        [JsonProperty("nullsubobjectwithconverter")]
        public object NullSubObjectWithConverter { get; set; }
    }

    public class sample_sub_object
    {
        [JsonProperty("pi")]
        public string Pi { get; set; }
    }


    [QueryStringParameterConverter(typeof(sample_type_converter))]
    public class sample_sub_object_with_custom_converter
    {
        public string Value { get; set; }
    }

    internal class sample_type_converter 
        : QueryStringParameterConverter<sample_sub_object_with_custom_converter>
    {
        public override string ConvertToQueryStringValue(sample_sub_object_with_custom_converter @object)
        {
            if (@object.Value == null) return null;

            return new string(@object.Value.Reverse().ToArray());
        }
    }
}
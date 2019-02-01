namespace Stripe
{
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Newtonsoft.Json;

    public abstract class StripeEntity : IStripeEntity
    {
        [JsonIgnore]
        public StripeResponse StripeResponse { get; set; }

        /// <summary>
        /// Deserializes the JSON to a Stripe object type. The type is automatically deduced from
        ///  the <c>object</c> key in the JSON string.
        /// </summary>
        /// <param name="value">The object to deserialize.</param>
        /// <returns>The deserialized Stripe object from the JSON string.</returns>
        public static IHasObject FromJson(string value)
        {
            return JsonConvert.DeserializeObject<IHasObject>(value, StripeConfiguration.SerializerSettings);
        }

        /// <summary>Deserializes the JSON to the specified Stripe object type.</summary>
        /// <typeparam name="T">The type of the Stripe object to deserialize to.</typeparam>
        /// <param name="value">The object to deserialize.</param>
        /// <returns>The deserialized Stripe object from the JSON string.</returns>
        public static T FromJson<T>(string value)
            where T : IStripeEntity
        {
            return JsonConvert.DeserializeObject<T>(value, StripeConfiguration.SerializerSettings);
        }

        /// <summary>Reports a Stripe object as a string.</summary>
        /// <returns>
        /// A string representing the Stripe object, including its JSON serialization.
        /// </returns>
        /// <seealso cref="ToJson"/>
        public override string ToString()
        {
            return string.Format(
                "<{0}@{1} id={2}> JSON: {3}",
                this.GetType().FullName,
                RuntimeHelpers.GetHashCode(this),
                this.GetIdString(),
                this.ToJson());
        }

        /// <summary>Serializes the Stripe object as a JSON string.</summary>
        /// <returns>An indented JSON string represensation of the object.</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(
                this,
                Formatting.Indented,
                StripeConfiguration.SerializerSettings);
        }

        private object GetIdString()
        {
            foreach (var property in this.GetType().GetTypeInfo().DeclaredProperties)
            {
                if (property.Name == "Id")
                {
                    return property.GetValue(this);
                }
            }

            return null;
        }
    }

    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleType", Justification = "Generic variant")]
    public abstract class StripeEntity<T> : StripeEntity
        where T : StripeEntity<T>
    {
        /// <summary>Deserializes the JSON to a Stripe object type.</summary>
        /// <param name="value">The object to deserialize.</param>
        /// <returns>The deserialized Stripe object from the JSON string.</returns>
        public static new T FromJson(string value)
        {
            return StripeEntity.FromJson<T>(value);
        }
    }
}

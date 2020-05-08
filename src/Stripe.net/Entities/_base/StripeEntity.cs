namespace Stripe
{
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Stripe.Infrastructure;

    [JsonObject(MemberSerialization.OptIn)]
    public abstract class StripeEntity : IStripeEntity
    {
        [JsonIgnore]
        private JObject rawJObject;

        [JsonIgnore]
        public JObject RawJObject
        {
            get
            {
                // Lazily initialize the object the first time the getter is called.
                if (this.rawJObject == null)
                {
                    if (this.StripeResponse == null)
                    {
                        return null;
                    }

                    this.rawJObject = JObject.Parse(this.StripeResponse.Content);
                }

                return this.rawJObject;
            }

            protected set
            {
                this.rawJObject = value;
            }
        }

        [JsonIgnore]
        public StripeResponse StripeResponse { get; set; }

        public static IHasObject FromJson(string value)
        {
            return JsonUtils.DeserializeObject<IHasObject>(value, StripeConfiguration.SerializerSettings);
        }

        public static T FromJson<T>(string value)
            where T : IStripeEntity
        {
            return JsonUtils.DeserializeObject<T>(value, StripeConfiguration.SerializerSettings);
        }

        public override string ToString()
        {
            return string.Format(
                "<{0}@{1} id={2}> JSON: {3}",
                this.GetType().FullName,
                RuntimeHelpers.GetHashCode(this),
                this.GetIdString(),
                this.ToJson());
        }

        public string ToJson()
        {
            return JsonUtils.SerializeObject(
                this,
                Formatting.Indented,
                StripeConfiguration.SerializerSettings);
        }

        protected static ExpandableField<T> SetExpandableFieldId<T>(
            string id,
            ExpandableField<T> expandable)
            where T : IHasId
        {
            if (expandable == null)
            {
                expandable = new ExpandableField<T>();
                expandable.Id = id;
            }
            else if (expandable.Id != id)
            {
                expandable.ExpandedObject = default;
                expandable.Id = id;
            }

            return expandable;
        }

        protected static ExpandableField<T> SetExpandableFieldObject<T>(
            T obj,
            ExpandableField<T> expandable)
            where T : IHasId
        {
            if (expandable == null)
            {
                expandable = new ExpandableField<T>();
            }

            expandable.ExpandedObject = obj;

            return expandable;
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
        public static new T FromJson(string value)
        {
            return StripeEntity.FromJson<T>(value);
        }
    }
}

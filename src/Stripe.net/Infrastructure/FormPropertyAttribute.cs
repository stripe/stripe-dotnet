namespace Stripe.Infrastructure
{
    using System;

    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public class FormPropertyAttribute : Attribute
    {
        private string name;

        public FormPropertyAttribute(string name)
        {
            this.name = name;
        }

        public virtual string Name
        {
            get { return this.name; }
        }
    }
}

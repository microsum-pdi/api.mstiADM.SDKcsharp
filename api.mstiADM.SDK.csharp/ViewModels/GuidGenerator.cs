using System;

namespace api.mstiADM.SDK.csharp.ViewModels
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AutoGuidAttribute : Attribute
    {
        private Guid _id;

        public AutoGuidAttribute()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id => _id;
    }
}

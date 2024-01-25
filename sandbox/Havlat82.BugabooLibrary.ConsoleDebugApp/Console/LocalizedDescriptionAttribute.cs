using System.ComponentModel;
using System.Resources;

namespace Havlat82.BugabooLibrary.ConsoleDebugApp.Console
{
    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private readonly string _resourceKey;
        private readonly ResourceManager _resourceManager;

        public LocalizedDescriptionAttribute(string resourceKey, Type resourceType)
        {
            _resourceKey = resourceKey;
            _resourceManager = new ResourceManager(resourceType);
        }

        public override string Description
        {
            get
            {
                var description = _resourceManager.GetString(_resourceKey);
                return string.IsNullOrWhiteSpace(description)
                    ? $"[[{_resourceKey}]]" : description;
            }
        }
    }
}

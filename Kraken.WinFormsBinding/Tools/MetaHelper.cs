using System.Collections.Generic;

namespace Kraken.WinFormsBinding.Tools
{
    public class MetaHelper
    {
        /// <summary>
        /// Returns each propertyvalue for each path segment sourced from given root.
        /// </summary>
        /// <param name="root">The root object is always returned as first item.</param>
        /// <param name="propertyPath">The path sourced from given root. Each property segment should be separated by a dot.</param>
        /// <returns></returns>
        public IEnumerable<object> ResolvePropertyPath(object root, string propertyPath)
        {
            if (root is null) throw new System.ArgumentNullException(nameof(root));
            if (string.IsNullOrWhiteSpace(propertyPath)) throw new System.ArgumentException("message", nameof(propertyPath));

            var propertyNames = propertyPath.Split('.');

            var resolvedObjects = new object[propertyNames.Length];

            object currentObject = root;
            for (int i = 0; i < resolvedObjects.Length; i++)
            {
                if (currentObject == null) break;

                resolvedObjects[i] = currentObject;
                var nextPath = propertyNames[i];

                var currentPropertyValue = currentObject.GetType().GetProperty(nextPath).GetValue(currentObject);
                currentObject = currentPropertyValue;
            }

            return resolvedObjects;
        }
    }
}

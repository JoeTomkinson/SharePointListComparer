using System.Collections.Generic;
using System.Linq;

namespace SharePointListComparer.Storage
{
    /// <summary>
    /// The purpose of this class is to enable Windows Store Apps to have a sessionstate, much like the capability of ASP.NET
    /// </summary>
    public static class ApplicationState
    {
        private static Dictionary<string, object> _values =
                   new Dictionary<string, object>();

        /// <summary>
        /// Sets a value in the dictionary with the entered values.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetValue(string key, object value)
        {
            if (_values.ContainsKey(key))
            {
                _values.Remove(key);
            }
            _values.Add(key, value);
        }

        /// <summary>
        /// Gets the object with the associated entered key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetValue<T>(string key)
        {
            if (_values.ContainsKey(key))
            {
                return (T)_values[key];
            }
            else
            {
                return default(T);
            }
        }

        /// <summary>
        /// Clears all values from the applicationstate
        /// </summary>
        public static void ClearValues()
        {
            _values.Clear();
        }

        /// <summary>
        /// Checks if the dictionary contains a value with a key equal to the entered string
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool ContainsValue(string key)
        {
            if (_values.ContainsKey(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets all values currently saved within the applicaiton state, in the form of a dictionary(string, object)
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, object> GetAllValues()
        {
            return _values;
        }

        /// <summary>
        /// Removes a KeyValuePair from the dictionary where the key equals the entered string
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            _values.Remove(key);
        }

        /// <summary>
        /// Removes all KeyValuePairs from the dictionary where the key starts with entered string
        /// </summary>
        /// <param name="startsWith"></param>
        public static void RemoveStartsWith(string startsWith)
        {
            var toRemove = _values.Where(x => x.Key.StartsWith(startsWith))
                         .Select(pair => pair.Key)
                         .ToList();

            foreach (var key in toRemove)
            {
                _values.Remove(key);
            }
        }
    }
}

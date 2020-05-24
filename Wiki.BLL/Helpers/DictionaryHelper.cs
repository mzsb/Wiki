using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiki.BLL.Helpers
{
    public static class DictionaryHelper
    {
        public static string GetStringValue<K, V>(this Dictionary<K, V> dictionary, K key) =>
            dictionary.TryGetValue(key, out V value) ? value.ToString() : string.Empty;

        public static string GetStringValue<K, V>(this Dictionary<K, V> dictionary, K key, K btwKey) =>
            dictionary.TryGetValue(key, out V value) ? value.ToString() : 
            dictionary.TryGetValue(btwKey, out V btwValue) ? btwValue.ToString() : string.Empty;

        public static string GetStringValue<K, V>(this Dictionary<K, V> dictionary) =>
            dictionary.FirstOrDefault().Value is V value ? value.ToString() : string.Empty;
    }
}

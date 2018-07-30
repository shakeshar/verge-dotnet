using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Verge.Core
{
    [DataContract]
    public class AppSettingKeyValue
    {
        [DataMember(Name = "settings")]
        public List<AppSettingKeyValueItem> Items { get; set; }

    }
    [DataContract]
    public class AppSettingKeyValueItem
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }
        [DataMember(Name = "value")]
        public object Value { get; set; }
    }
    public class AppSettings : IAppSettings
    {
        public AppSettingKeyValue Settings { get; set; }
        public AppSettings(string appSettingsConfig)
        {
            string appsettingsContent = File.ReadAllText(appSettingsConfig);
            Settings = Newtonsoft.Json.JsonConvert.DeserializeObject<AppSettingKeyValue>(appsettingsContent);
        }
        public T GetValue<T>(string key)
        {
            var result = Settings.Items.FirstOrDefault(px => px.Key == key);
            return (T)result.Value;
        }
        public decimal GetDecimalValue(string key)
        {
            var result = Settings.Items.FirstOrDefault(px => px.Key == key);
            return Convert.ToDecimal(result.Value);
        }
    }
    public interface IAppSettings
    {
        T GetValue<T>(string key);
        decimal GetDecimalValue(string key);
    }
}

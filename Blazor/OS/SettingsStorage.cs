using System;
using System.Collections.Generic;
using System.Linq;


namespace Blazor.OS
{
    using System.Threading.Tasks;
    using Core.Lib.OS;
    using System.Runtime.CompilerServices;
    public class SettingsStorage : ISettingsStorage
    {
        internal class Values
        {
            public string WebAPIUrl { get; set; }
        }
        internal static Values CurrentValues { get; set; }
        public T GetValue<T>([CallerMemberName] string propertyName = null)
        {
            T value = default(T);
            switch (propertyName)
            {
                case "WebAPIUrl":
                    value = (T)(object)CurrentValues.WebAPIUrl;
                    break;
            }
            return value;
        }
        public void SetValue<T>(T newValue = default, [CallerMemberName] string propertyName = null)
        {
            throw new System.NotImplementedException();
        }


    }
}

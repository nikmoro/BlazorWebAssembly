using System.Runtime.CompilerServices;


namespace Core.Lib.OS
{
    interface ISettingsStorage
    {
        void SetValue<T>(T newValue = default, [CallerMemberName] string propertyName = null);
        T GetValue<T>([CallerMemberName] string propertyName = null);
    }
}

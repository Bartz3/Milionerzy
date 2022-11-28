using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MilionerzyWPF
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        protected void Set<T>(T value, ref T field, [CallerMemberName] string name = "")
        {
            field = value;
            PropertyChanged?.Invoke(this, new(name));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

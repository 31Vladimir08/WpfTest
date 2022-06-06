using System.ComponentModel;
using System.Runtime.CompilerServices;

using ReactiveUI;

namespace WpfApp
{
    public abstract class PropertyChangedBase : ReactiveObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

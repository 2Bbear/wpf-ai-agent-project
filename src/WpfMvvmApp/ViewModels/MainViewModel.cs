using WpfMvvmApp.Common;

namespace WpfMvvmApp.ViewModels;

public sealed class MainViewModel : ObservableObject
{
    private int count;

    public MainViewModel()
    {
        IncrementCommand = new RelayCommand(() => Count++);
        ResetCommand = new RelayCommand(() => Count = 0, () => Count > 0);
    }

    public int Count
    {
        get => count;
        private set
        {
            if (count == value)
            {
                return;
            }

            count = value;
            OnPropertyChanged();
            ResetCommand.NotifyCanExecuteChanged();
        }
    }

    public RelayCommand IncrementCommand { get; }

    public RelayCommand ResetCommand { get; }
}

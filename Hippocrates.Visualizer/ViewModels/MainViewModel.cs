using System.Windows;
using System.Windows.Input;
using Hippocrates.Visualizer.Mvvm.Commands;

namespace Hippocrates.Visualizer.ViewModels
{
  public class MainViewModel
  {
    public MainViewModel()
    {
      CloseCommand = new DelegateCommand(Close);
    }

    public ICommand CloseCommand { get; }

    private static void Close()
    {
      Application.Current.MainWindow.Close();
    }
  }
}
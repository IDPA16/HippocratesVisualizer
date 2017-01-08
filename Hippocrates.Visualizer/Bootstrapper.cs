using Hippocrates.Visualizer.Dialogs;
using Hippocrates.Visualizer.Mvvm;
using Hippocrates.Visualizer.ViewModels;
using Hippocrates.Visualizer.Views;

namespace Hippocrates.Visualizer
{
  public sealed class Bootstrapper : BootstrapperBase<MainView>
  {
    public Bootstrapper() : base(new DialogProviderService(), false)
    {
      SetStartupWindow(new MainView() { DataContext = new MainViewModel() });
    }
  }
}
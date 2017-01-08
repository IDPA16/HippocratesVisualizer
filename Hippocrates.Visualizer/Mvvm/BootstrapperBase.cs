using System;
using System.Reflection;
using System.Windows;
using Hippocrates.Visualizer.Mvvm.Interactions;
using Hippocrates.Visualizer.Mvvm.Interactions.Services;

namespace Hippocrates.Visualizer.Mvvm
{
  public class BootstrapperBase<TSTartupWindow> where TSTartupWindow : Window
  {
    private readonly Window window;

    public BootstrapperBase(IInteractionProvider interactionProvider)
    {
      InteractionRequest.InteractionRequestAdded += (sender, args) => interactionProvider.RegisterInteraction(args.AddedInteraction);
      window = typeof(TSTartupWindow).GetConstructor(new Type[] {}).Invoke(null) as TSTartupWindow;
    }

    public virtual void StartApplication()
    {
      window.Show();
    }

    protected virtual void ConfigureStartupWindow(object viewModel)
    {
      window.DataContext = viewModel;
    }

  }
}
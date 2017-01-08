using System;
using System.Windows;
using Hippocrates.Visualizer.Mvvm.Interactions;
using Hippocrates.Visualizer.Mvvm.Interactions.Services;

namespace Hippocrates.Visualizer.Mvvm
{
  public class BootstrapperBase<TSTartupWindow> where TSTartupWindow : Window
  {
    private TSTartupWindow window;

    public BootstrapperBase(IInteractionProvider interactionProvider, bool autoconfigureWindow = true)
    {
      InteractionRequest.InteractionRequestAdded += (sender, args) => interactionProvider.RegisterInteraction(args.AddedInteraction);
      // ReSharper disable once PossibleNullReferenceException
      if (autoconfigureWindow)
      {
        // if the code fails here, the set window has no public constructor with 
        window = typeof(TSTartupWindow).GetConstructor(new Type[] { }).Invoke(null) as TSTartupWindow;
      }
    }

    public virtual void StartApplication()
    {
      window.Show();
    }

    protected virtual void SetStartupWindow(TSTartupWindow startupWindow)
    {
      window = startupWindow;
    }

    protected virtual void ConfigureStartupWindow(object viewModel)
    {
      window.DataContext = viewModel;
    }

  }
}
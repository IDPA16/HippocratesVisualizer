using System;
using System.Collections.Generic;
using System.Windows;
using Hippocrates.Visualizer.Mvvm.Interactions;
using Hippocrates.Visualizer.Mvvm.Interactions.Services;

namespace Hippocrates.Visualizer.Dialogs
{
  public class DialogProviderService : IInteractionProvider
  {
    public void RegisterInteraction(InteractionRequest request)
    {
      request.Raised += RequestOnRaised;
    }
    
    private void RequestOnRaised(object sender, UserInteractionRequestedEventArgs userInteractionRequestedEventArgs)
    {
      throw new NotImplementedException();
    }
  }
}

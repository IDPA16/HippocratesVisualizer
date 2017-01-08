using System;

namespace Hippocrates.Visualizer.Mvvm.Interactions
{
  public class UserInteractionRequestedEventArgs
  {
    /// <summary>Gets the context for a requested interaction.</summary>
    public IUserInteraction Context { get; private set; }

    public UserInteractionRequestedEventArgs(IUserInteraction context)
    {
      Context = context;
    }

  }
}
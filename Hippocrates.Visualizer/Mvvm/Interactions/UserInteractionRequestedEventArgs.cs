using System;

namespace Hippocrates.Visualizer.Mvvm.Interactions
{
  public class UserInteractionRequestedEventArgs
  {
    /// <summary>Gets the context for a requested interaction.</summary>
    public IUserInteraction Context { get; private set; }

    /// <summary>
    /// Gets the callback to execute when an interaction is completed.
    /// </summary>
    public Action Callback { get; private set; }

    public UserInteractionRequestedEventArgs(IUserInteraction context, Action callback)
    {
      Context = context;
      Callback = callback;
    }

  }
}
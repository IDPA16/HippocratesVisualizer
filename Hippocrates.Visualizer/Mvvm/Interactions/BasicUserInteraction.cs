using System;
using System.Collections.Generic;
using Hippocrates.Visualizer.Mvvm.Interactions.Options;

namespace Hippocrates.Visualizer.Mvvm.Interactions
{
  public class BasicUserInteraction : IUserInteraction
  {
    public BasicUserInteraction(string title, object content, IList<IInteractionOption<IUserInteraction>> interactionOptions)
    {
      Title = title;
      Content = content;
      InteractionOptions = interactionOptions;
    }

    public string Title { get; }

    public object Content { get; }

    public IList<IInteractionOption<IUserInteraction>> InteractionOptions { get; }

    public static BasicUserInteraction Confirmation(string title, string message, Action<IUserInteraction> yesCallback, Action<IUserInteraction> noCallback)
    {
      return new BasicUserInteraction(
        title, 
        message, 
        new IInteractionOption<IUserInteraction>[]
        {
          BasicInteractionOption.Yes(yesCallback),
          BasicInteractionOption.No(noCallback)
        });
    }

    public static BasicUserInteraction Information(string title, string message, Action<IUserInteraction> confirmationCallback)
    {
      return new BasicUserInteraction(
        title, 
        message, 
        new IInteractionOption<IUserInteraction>[]
        {
          BasicInteractionOption.Ok(confirmationCallback),
        });
    }
  }
}
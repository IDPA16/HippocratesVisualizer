using System.Collections.Generic;
using Hippocrates.Visualizer.Mvvm.Interactions.Options;

namespace Hippocrates.Visualizer.Mvvm.Interactions
{
  public interface IUserInteraction
  {
    string Title { get; }

    object Content { get; }

    IList<IInteractionOption<IUserInteraction>> InteractionOptions { get; }
  }
}
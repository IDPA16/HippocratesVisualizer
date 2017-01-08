using System;

namespace Hippocrates.Visualizer.Mvvm.Interactions.Options
{
  public interface IInteractionOption<in TCallbackParameter>
  {
    string Name { get; }

    Action<TCallbackParameter> Callback { get; }
  }
}
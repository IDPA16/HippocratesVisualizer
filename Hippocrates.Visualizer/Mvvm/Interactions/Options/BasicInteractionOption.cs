using System;

namespace Hippocrates.Visualizer.Mvvm.Interactions.Options
{
  public class BasicInteractionOption : IInteractionOption<IUserInteraction>
  {
    public BasicInteractionOption(string name, Action<IUserInteraction> callback)
    {
      Name = name;
      Callback = callback;
    }

    public string Name { get; }

    public Action<IUserInteraction> Callback { get; }

    public static BasicInteractionOption Ok(Action<IUserInteraction> callback) => new BasicInteractionOption("Ok", callback);

    public static BasicInteractionOption Cancel(Action<IUserInteraction> callback) => new BasicInteractionOption("Cancel", callback);

    public static BasicInteractionOption Yes(Action<IUserInteraction> callback) => new BasicInteractionOption("Yes", callback);

    public static BasicInteractionOption No(Action<IUserInteraction> callback) => new BasicInteractionOption("No", callback);
  }
}
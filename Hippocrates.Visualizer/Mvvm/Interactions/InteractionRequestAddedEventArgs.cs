namespace Hippocrates.Visualizer.Mvvm.Interactions
{
  public class InteractionRequestAddedEventArgs : System.EventArgs
  {
    public InteractionRequestAddedEventArgs(InteractionRequest addedInteraction)
    {
      AddedInteraction = addedInteraction;
    }
    
    public InteractionRequest AddedInteraction { get; }
  }
}
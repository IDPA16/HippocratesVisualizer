using System;

namespace Hippocrates.Visualizer.Mvvm.Interactions
{
  // Adapted from Prism.IInteractionRequest and its implementation InteractionRequest<T>, changed and 
  // extended to fit the avalonia system and allow InteractionProviders to be used properly (without pain).
  public class InteractionRequest
  {
    private InteractionRequest() { } // private constructor to force users to use InteractionRequest.Register() 
                                     // instead of creating the object directly in the class.
                                     // this allows better useage of InteractionProviders

    #region InteractionRequest registering
    // if needed, this and the below, also commented lines can be uncommented to allow access to all availabe interactionRequests.
    //private static readonly List<InteractionRequest> interactionRequests = new List<InteractionRequest>();

    /// <summary>
    /// Constructs a InteractionRequest and informs registered listeners 
    /// that a new InteractionRequest has been added.
    /// </summary>
    /// <returns>The newly constructed InteractionRequest</returns>
    public static InteractionRequest Register()
    {
      var request = new InteractionRequest();
      //interactionRequests.Add(request);
      InteractionRequestAdded?.Invoke(null, new InteractionRequestAddedEventArgs(request));
      return request;
    }

    public static event EventHandler<InteractionRequestAddedEventArgs> InteractionRequestAdded;
    #endregion

    /// <summary>Fired when interaction is needed.</summary>
    public event EventHandler<UserInteractionRequestedEventArgs> Raised;

    /// <summary>Fires the Raised event.</summary>
    /// <param name="context">The context for the interaction request.</param>
    public void Raise(IUserInteraction context)
    {
      Raised?.Invoke(this, new UserInteractionRequestedEventArgs(context));
    }

  }
}
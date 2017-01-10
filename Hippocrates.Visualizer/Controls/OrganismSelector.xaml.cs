using System.Windows;
using System.Windows.Controls;

namespace Hippocrates.Visualizer.Controls
{
  /// <summary>
  /// Interaction logic for OrganismSelector.xaml
  /// </summary>
  public partial class OrganismSelector : Grid
  {
    public OrganismSelector()
    {
      InitializeComponent();
    }

    public static readonly DependencyProperty SelectedGenerationIndexProperty = DependencyProperty.Register(
      nameof(SelectedGenerationIndex), typeof(int), typeof(OrganismSelector), new PropertyMetadata(default(int)));

    public int SelectedGenerationIndex
    {
      get { return (int) GetValue(SelectedGenerationIndexProperty); }
      set { SetValue(SelectedGenerationIndexProperty, value); }
    }

    public static readonly DependencyProperty SelectedSpeciesIndexProperty = DependencyProperty.Register(
      nameof(SelectedSpeciesIndex), typeof(int), typeof(OrganismSelector), new PropertyMetadata(default(int)));

    public int SelectedSpeciesIndex
    {
      get { return (int) GetValue(SelectedSpeciesIndexProperty); }
      set { SetValue(SelectedSpeciesIndexProperty, value); }
    }

    public static readonly DependencyProperty SelectedOrganismIndexProperty = DependencyProperty.Register(
      nameof(SelectedOrganismIndex), typeof(int), typeof(OrganismSelector), new PropertyMetadata(default(int)));
    
    public int SelectedOrganismIndex
    {
      get { return (int) GetValue(SelectedOrganismIndexProperty); }
      set { SetValue(SelectedOrganismIndexProperty, value); }
    }
  }
}

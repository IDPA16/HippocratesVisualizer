using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hippocrates.Visualizer.Controls
{
  /// <summary>
  /// Interaction logic for TitledListView.xaml
  /// </summary>
  public partial class TitledListView : Grid
  {
    public TitledListView()
    {
      InitializeComponent();
    }

    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
      nameof(Title), typeof(string), typeof(TitledListView), new PropertyMetadata(default(string)));

    public string Title
    {
      get { return (string) GetValue(TitleProperty); }
      set { SetValue(TitleProperty, value); }
    }

    public static readonly DependencyProperty ListViewItemsProperty = DependencyProperty.Register(
      nameof(ListContent), typeof(List<string>), typeof(TitledListView), new PropertyMetadata(default(List<string>)));

    public List<string> ListContent
    {
      get { return (List<string>) GetValue(ListViewItemsProperty); }
      set { SetValue(ListViewItemsProperty, value); }
    }
  }
}

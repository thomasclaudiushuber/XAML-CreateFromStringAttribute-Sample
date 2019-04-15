using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using XamlCreateFromStringSample.Models;

namespace XamlCreateFromStringSample.Controls
{
  public sealed partial class CustomerDetailControl : UserControl
  {
    public CustomerDetailControl()
    {
      this.InitializeComponent();
    }

    public Customer Customer
    {
      get { return (Customer)GetValue(CustomerProperty); }
      set { SetValue(CustomerProperty, value); }
    }

    public static readonly DependencyProperty CustomerProperty =
        DependencyProperty.Register("Customer", typeof(Customer), typeof(CustomerDetailControl), new PropertyMetadata(null));
  }
}

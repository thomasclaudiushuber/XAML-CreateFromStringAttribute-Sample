using Windows.Foundation.Metadata;

namespace XamlCreateFromStringSample.Models
{
  [CreateFromString(MethodName = "XamlCreateFromStringSample.Models.Customer.CreateFromString")]
  public class Customer
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public static Customer CreateFromString(string customerString)
    {
      var array = customerString.Split(' ');
      return new Customer
      {
        FirstName = array[0],
        LastName = array[1]
      };
    }
  }
}

using System.Windows.Controls;
using UserControlDemo.App.Models;

namespace UserControlDemo.App.Components;

public partial class ProductCardComponent : UserControl
{
    public Product Product { get; set; }

    public ProductCardComponent(Product product)
    {
        Product = product;

        InitializeComponent();
    }
}

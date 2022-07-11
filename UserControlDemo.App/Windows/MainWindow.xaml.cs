using System.Collections.Generic;
using System.Windows;
using UserControlDemo.App.Components;
using UserControlDemo.App.Models;

namespace UserControlDemo.App.Windows;

public partial class MainWindow : Window
{
    public List<Product> Products { get; set; }

    public MainWindow()
    {
        Products = new List<Product>
        {
            new() { Article = "art_121", Name = "Product 1", Price = 100 },
            new() { Article = "art_121", Name = "Product 1", Price = 100 },
            new() { Article = "art_121", Name = "Product 1", Price = 100 },
            new() { Article = "art_121", Name = "Product 1", Price = 100 }
        };

        InitializeComponent();

        InitPanel();
    }

    private void InitPanel()
    {
        foreach (var product in Products)
        {
            var card = new ProductCardComponent(product);
            card.Style = (Style)Resources["StyleDefault"];
            Panel.Children.Add(card);
        }
    }
}

using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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
            var card = new ProductCardComponent(product)
            {
                Style = (Style)Resources["StyleDefault"]
            };

            /*
            var card = new Border
                {
                    Child = new Grid(), 
                    BorderBrush = new SolidColorBrush(Colors.Black), 
                    BorderThickness = new Thickness(2)
                };

            ((Grid)card.Child).RowDefinitions.Add(new RowDefinition());
            ((Grid)card.Child).RowDefinitions.Add(new RowDefinition());
            ((Grid)card.Child).RowDefinitions.Add(new RowDefinition());
            var article = new TextBlock { Text = product.Article };
            var name = new TextBlock { Text = product.Name };
            var price = new TextBlock { Text = product.Price.ToString(CultureInfo.CurrentCulture) };
            
            Grid.SetRow(article, 0);
            Grid.SetRow(name, 1);
            Grid.SetRow(price, 2);

            ((Grid)card.Child).Children.Add(article);
            ((Grid)card.Child).Children.Add(name);
            ((Grid)card.Child).Children.Add(price);
            */
            
            Panel.Children.Add(card);
        }
    }
}

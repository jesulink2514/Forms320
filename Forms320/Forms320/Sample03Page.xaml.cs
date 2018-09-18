using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms320
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sample03Page : ContentPage
	{
		public Sample03Page ()
		{
			InitializeComponent ();

            Items = new List<Item>()
            {
                new Item("Item 01","lorem ipsum ador met"),
                new Item("Item 02","lorem ipsum ador met"),
                new Item("Item 03","lorem ipsum ador met"),
                new Item("Item 04","lorem ipsum ador met"),
                new Item("Item 05","lorem ipsum ador met"),
                new Item("Item 06","lorem ipsum ador met"),
                new Item("Item 07","lorem ipsum ador met")
            };

            BindingContext = this;
		}

        public List<Item> Items { get; set;}
    }

    public class Item
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public Item(string title,string detail)
        {
            Title = title;
            Detail = detail;
        }
    }
}
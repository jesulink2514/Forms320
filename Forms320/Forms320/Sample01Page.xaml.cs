using Xamarin.Forms;

namespace Forms320
{
    public partial class Sample01Page : ContentPage
    {
        public Sample01Page()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public string FirstName { get; set; } = "Jesus";
        public string LastName { get; set; } = "Angulo";
        public string Twitter { get; set; } = "@jesulink2514";
    }
}

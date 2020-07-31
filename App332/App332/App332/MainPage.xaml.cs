using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App332
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        FBProduct testP { get; set; }
        public MainPage()
        {
            InitializeComponent();

            testP  = new FBProduct();

            testP.ProductName = "Apple";
            testP.ProductPrice = "37.95";
            testP.ProductImage = "Image goes here";
            testP.ShoppingCartItemTotals = "default vaule of ShoppingCartItemTotals";

            BindingContext = testP;

        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //get qty
            double qty = e.NewValue;

            Stepper currentStepper = sender as Stepper;

            FBProduct currentProduct = currentStepper.BindingContext as FBProduct;

            //get price
            double price = Convert.ToDouble(currentProduct.ProductPrice);

            testP.ShoppingCartItemTotals = (qty * price).ToString();

        }
    }

    public class FBProduct : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public string ProductName { get; internal set; }
        public string ProductPrice { get; internal set; }
        public string ProductImage { get; internal set; }

        string shoppingCartItemTotals;

        public string ShoppingCartItemTotals
        {
            set
            {
                if (shoppingCartItemTotals != value)
                {
                    shoppingCartItemTotals = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ShoppingCartItemTotals"));
                    }
                }
            }
            get
            {
                return shoppingCartItemTotals;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckOut
{
    public partial class MainPage : ContentPage
    {

        // public List<Product> ProdList;

        public ObservableCollection<Product> ProdList { get; set; }



        public MainPage()
        {
            InitializeComponent();
            GetProduct();
            ListProducts.ItemsSource = ProdList;
            Step2Layout.IsVisible = false;

            Step3Layout.IsVisible = false;

            Step1Layout.IsVisible = true;
            //BindingContext = this;


            //if (BindingContext.Equals(Button_OnBackStep1Clicked()))
            //{
            //    if (stepBar.StepSelected.Equals(1))
            //    {
            //        BindingContext = Step1Layout;
            //    }
            //}
        }


        void GetProduct()
        {
            ProdList = new ObservableCollection<Product>
            {

                new Product
                {
                    Name = "Gucci er",
                    ShortDescription = "Almost New",
                    Price = "3000.00 SAR",
                    ImageURL = "Pic1.png"
                },
                new Product
                {
                    Name = "Gucci Hand Bag Light Brown",
                    ShortDescription = "Almost New",
                    Price = "3000.00 SAR",
                    ImageURL = "Pic1.png"
                },

                new Product
                {
                    Name = "Gucci er",
                    ShortDescription = "Almost New",
                    Price = "3000.00 SAR",
                    ImageURL = "Pic1.png"
                }
            };
        }



        private void Button_OnBackStep3Clicked(object sender, EventArgs e)

        {

            Step2Layout.IsVisible = true;

            Step3Layout.IsVisible = false;

            Step1Layout.IsVisible = false;
            INStep1.BackgroundColor = Color.FromHex("#443e42");


        }

        private void Button_OnNextStep3Clicked(object sender, EventArgs e)

        {



        }

        private void Button_OnBackStep2Clicked(object sender, EventArgs e)

        {

            Step2Layout.IsVisible = false;

            Step3Layout.IsVisible = false;

            Step1Layout.IsVisible = true;

        }

        private void Button_OnNextStep2Clicked(object sender, EventArgs e)

        {

            Step2Layout.IsVisible = false;

            Step3Layout.IsVisible = true;

            Step1Layout.IsVisible = false;

        }

        private void Button_OnBackStep1Clicked(object sender, EventArgs e)

        {

        }

        private void Button_OnNextStep1Clicked(object sender, EventArgs e)

        {

            Step2Layout.IsVisible = true;

            Step3Layout.IsVisible = false;

            Step1Layout.IsVisible = false;

          
        }



        private void TapGestureRecognizer_OnCreditCardTapped(object sender, EventArgs e)

        {

            CreditCardFrame.BackgroundColor = Color.Black;

            BankTransferFrame.BackgroundColor = Color.Gainsboro;

        }

        private void TapGestureRecognizer_OnBankTransferTapped(object sender, EventArgs e)

        {

            CreditCardFrame.BackgroundColor = Color.Gainsboro;

            BankTransferFrame.BackgroundColor = Color.Black;

        }



        private void TapGestureRecognizer_OnExpressShippingTapped(object sender, EventArgs e)

        {

            ExpressShippingFrame.BackgroundColor = Color.Black;

            NormalShippingFrame.BackgroundColor = Color.Gainsboro;

        }

        private void TapGestureRecognizer_OnNormalShippingTapped(object sender, EventArgs e)

        {

            ExpressShippingFrame.BackgroundColor = Color.Gainsboro;

            NormalShippingFrame.BackgroundColor = Color.Black;

        }

        private void TapGestureRecognizerDel_OnTapped(object sender, EventArgs e)

        {


            
            var remove = sender as Image;
            var product = remove.BindingContext as Product;
            ProdList.Remove(product);







            // public static BindableProperty ItemClickCommandProperty = BindableProperty.Create(nameof(ItemClickCommand), typeof(ICommand), typeof(Product), null);



            // public ICommand ItemClickCommand

            // {

            //     get { return (ICommand) this.GetValue(ItemClickCommandProperty); }

            //     set { this.SetValue(ItemClickCommandProperty, value); }
            // }



        }
    }
}


using System;
using System.Collections.Generic;
using Rangkakata.ViewModels;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.Pages
{
    public partial class InvoicePage : ContentPage
    {
        public InvoicePage()
        {

            ViewModel = new InvoicePageViewModel(new PageService());
            InitializeComponent();
        }

        public InvoicePageViewModel ViewModel
        {
            get { return BindingContext as InvoicePageViewModel; }
            set { BindingContext = value; }
        }
    }
}

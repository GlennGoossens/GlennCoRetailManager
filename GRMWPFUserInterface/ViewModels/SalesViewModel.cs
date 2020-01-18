using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRMWPFUserInterface.ViewModels
{
    public class SalesViewModel : Screen
    {
		private BindingList<string> _products;

		public BindingList<string> Products
		{
			get { return _products; }
			set { 
				_products = value;
				NotifyOfPropertyChange(() => Products);
			}
		}

		private string _itemQuantity;

		public string ItemQuantity
		{
			get { return _itemQuantity; }
			set { 
				_itemQuantity = value;
				NotifyOfPropertyChange(() => ItemQuantity);
			}
		}

		private BindingList<string> _cart;

		public BindingList<string> Cart
		{
			get { return _cart; }
			set { _cart = value;
				NotifyOfPropertyChange(() => Cart);
			}
		}

		public string SubTotal
		{
			get { return ""; }
			
		}
		public string Tax
		{
			get { return ""; }

		}
		public string Total
		{
			get { return ""; }

		}



		public bool canAddToCart {
			get {
				bool output = false;
				//make sure something is selected
				//make sure there is an item quantity

				return output;
			}  
		}

		public void AddToCart()
		{

		}

		public bool canRemoveToCart
		{
			get
			{
				bool output = false;
				//make sure something is selected

				return output;
			}
		}

		public void RemoveToCart()
		{

		}

		public bool canCheckOut
		{
			get
			{
				bool output = false;
				//make sure something is in the cart

				return output;
			}
		}

		public void CheckOut()
		{

		}


	}
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //
            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        #endregion

        #region METHODS

        private Company GetCompanyData()
        {
            return new Company()
            {
                Installment = "The 1st James Bond Movie",
            };
        }

        private Product GetProductData()
        {
            return
                new Product()
                {
                    Id = 1,
                    MovieTitle = "Dr. No",
                    Director = "Terence Young",
                    Actor = "Sean Connery",
                    Villain = "Dr. No",
                    ImageFileName = "drNo.jpg",
                    Description = "James Bond's investigation of a missing colleague in Jamaica leads him to the island of the mysterious Dr. No and a scheme to end the US space program.",
                    ReleaseDate = DateTime.Parse("10-05-1962"),
                    BoxOfficeGross = 59500000
                };
        }

        #endregion

        #region EVENTS


        #endregion

    }
}

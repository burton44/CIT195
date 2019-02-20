using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product : ObservableObject
    {
        #region ENUMS

        public enum GenderType { none, male, female }

        #endregion

        #region FIELDS

        private int _id;
        private string _firstName;
        private string _lastName;
        private string _actor;
        private string _villain;
        private string _imageFileName;
        private string _description;
        private DateTime _hireDate;
        private double _averageAnnualGross;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string MovieTitle
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChangedEvent("FullName"); // update items bound to the FullName property
            }
        }

        public string Director
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChangedEvent("FullName"); // update items bound to the FullName property
            }
        }

        public string Actor
        {
            get { return _actor; }
            set { _actor = value; }
        }
        
        public string Villain
        {
            get { return _villain; }
            set { _villain = value; }
        }

        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }
        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime ReleaseDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        public double BoxOfficeGross
        {
            get { return _averageAnnualGross; }
            set { _averageAnnualGross = value; }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}

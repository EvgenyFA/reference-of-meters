using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefData;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

namespace RefClient.ViewModel
{
    class MainWindowViewModel: INotifyPropertyChanged, IDisposable
    {
        private RefEntities _dataContext;

        public MainWindowViewModel()
        {
            _dataContext = new RefEntities();

            RefList = new ObservableCollection<ObservableCollection<BaseRefModel>>();
            SelectedRef = new ObservableCollection<BaseRefModel>();
            MeterRef = new ObservableCollection<BaseRefModel>(_dataContext.METER_REF);
            BronOrgRef = new ObservableCollection<BaseRefModel>(_dataContext.BRON_ORG_REF);
            FactorkzRef = new ObservableCollection<BaseRefModel>(_dataContext.FACTORKZ_REF);

            RefListView = CollectionViewSource.GetDefaultView(RefList);
            RefListView.Filter = FilterRefList;

            RefView = CollectionViewSource.GetDefaultView(SelectedRef);
            RefView.Filter = FilterRefView;

            names = "collection";
                     
            RefList.Add(MeterRef);
            RefList.Add(BronOrgRef);
            RefList.Add(FactorkzRef);
        }

        #region Properties 
        private ObservableCollection<ObservableCollection<BaseRefModel>> _RefList;
        public ObservableCollection<ObservableCollection<BaseRefModel>> RefList
        {
            get { return _RefList; }
            set
            {
                if ( _RefList != value )
                {
                    _RefList = value;
                    OnPropertyChanged("RefList");
                }
            }
        }

        private ICollectionView _RefListView;
        public ICollectionView RefListView
        {
            get { return _RefListView; }
            set
            {
                if(_RefListView != value)
                {
                    _RefListView = value;
                    OnPropertyChanged("RefListView");
                }
            }
        }

        private ICollectionView _RefView;
        public ICollectionView RefView
        {
            get { return _RefView; }
            set
            {
                if(_RefView != value)
                {
                    _RefView = value;
                    OnPropertyChanged("RefView");
                }
            }
        }

        private ObservableCollection<BaseRefModel> _MeterRef;
        public ObservableCollection<BaseRefModel> MeterRef
        {
            get { return _MeterRef; }
            set
            {
                if( _MeterRef != value )
                {
                    _MeterRef = value;
                    OnPropertyChanged("MeterRef");
                }
            }
        }

        private ObservableCollection<BaseRefModel> _BronOrgRef;
        public ObservableCollection<BaseRefModel> BronOrgRef
        {
            get { return _BronOrgRef; }
            set
            {
                if( _BronOrgRef != value )
                {
                    _BronOrgRef = value;
                    OnPropertyChanged("BronOrgRef");
                }
            }
        }

        private ObservableCollection<BaseRefModel> _FactorkzRef;
        public ObservableCollection<BaseRefModel> FactorkzRef
        {
            get { return _FactorkzRef; }
            set
            {
                if(_FactorkzRef != value)
                {
                    _FactorkzRef = value;
                    OnPropertyChanged("FactorkzRef");
                }
            }
        }

        private ObservableCollection<BaseRefModel> _SelectedRef;
        public ObservableCollection<BaseRefModel> SelectedRef
        {
            get { return _SelectedRef; }
            set
            {
                if (_SelectedRef != value)
                {
                    _SelectedRef = value;
                    OnPropertyChanged("SelectedRef");                    
                    RefView = CollectionViewSource.GetDefaultView(value);
                    if (value != null)
                    {
                        RefView.Filter = FilterRefView;
                        RefView.Refresh();
                    }
                }
            }
        }

        private BaseRefModel _SelectedProperty;
        public BaseRefModel SelectedProperty
        {
            get { return _SelectedProperty; }
            set
            {
                if( _SelectedProperty != value )
                {
                    _SelectedProperty = value;
                    OnPropertyChanged("SelectedProperty");
                }
            }
        }

        private int _selectedIndexOfRefList;
        public int selectedIndexOfRefList
        {
            get { return _selectedIndexOfRefList; }
            set
            {
                if (_selectedIndexOfRefList != value)
                {
                    _selectedIndexOfRefList = value;
                    OnPropertyChanged("selectedIndexOfRefList");
                }
            }
        }

        private string _filterRefListString = "";
        public string filterRefListString
        {
            get { return _filterRefListString; }
            set
            {
                if (_filterRefListString != value)
                {
                    _filterRefListString = value;
                    OnPropertyChanged("filterRefListString");
                    if(RefListView != null) RefListView.Refresh();
                }
            }
        }

        private string _filterRefString = "";
        public string filterRefString
        {
            get { return _filterRefString; }
            set
            {
                if(_filterRefString != value)
                {
                    _filterRefString = value;
                    OnPropertyChanged("filterRefString");
                    if(RefView != null) RefView.Refresh();
                }
            }
        }

        private string _names;
        public string names
        {
            get { return _names; }
            set
            {
                if(_names != value)
                {
                    _names = value;
                    OnPropertyChanged("names");
                }
            }
        }
        #endregion

        #region Methods
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool FilterRefList(object item)
        {
            ObservableCollection<BaseRefModel> obj = item as ObservableCollection<BaseRefModel>;
            string objstr = obj[0].Nameref.ToLower();
            return objstr.Contains(filterRefListString.ToLower());
        }

        private bool FilterRefView(object item)
        {
            BaseRefModel obj = item as BaseRefModel;
            string objstr = obj.Objects.ToLower();
            return objstr.Contains(filterRefString.ToLower());
        }

        public void SaveChanges()
        {
            try
            {
                _dataContext.SaveChanges();
            }
            catch(InvalidOperationException e)
            {
                MessageBox.Show(e.ToString(), "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace HelloMicrosoft.ViewModel
{
    class LostAndFoundPageViewMode
    {
        public string next_page_url { get; set; }
        public ObservableCollection<LFItem> data = new ObservableCollection<LFItem>();
        //public ObservableCollection<LFItem> Data
        //{
        //    get
        //    {
        //        return data;
        //    }
        //    set
        //    {
        //        this.data = value;
        //        OnPropertyChanged("Data");
        //    }
        //}
        //protected void OnPropertyChanged(string propertyName)
        //{
        //    if (this.PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
    }
    class LFItem
    {
        public string pro_id;
        public string connect_name;
        public string created_at;
        public string pro_description;
        public string pro_name;
        public string Category { get { return "来自分类 " + pro_name; } }
        public string wx_avatar;
        public BitmapImage HeadImg;
    }
}

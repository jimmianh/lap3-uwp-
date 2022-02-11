using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UNVApp01
{
    
    public class MyItem
    {
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
    }
    public sealed partial class MainPage : Page
    {
        List<MyItem> listImages = new List<MyItem>();
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            InitImage();
            flipView.ItemsSource = listImages;
        }

        private void InitImage()
        {
            listImages.Add(new MyItem()
            {
                ImageName = "em bé xinh đẹp ",
                ImagePath = "/Assets/ebe3.jpg"
            });
            listImages.Add(new MyItem()
            {
                ImageName = "em bé này tên là thuhang",
                ImagePath = "/Assets/ebe2.jpg"
            });
            listImages.Add(new MyItem()
            {
                ImageName = "Đáng iu vcl",
                ImagePath = "/Assets/ebe1.jpg"
            });
        }
    }
}

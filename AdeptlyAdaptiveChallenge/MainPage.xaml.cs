using AdeptlyAdaptiveChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdeptlyAdaptiveChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Models.NewsItem> NewsItem; 

        public MainPage()
        {
            this.InitializeComponent();
            NewsItem = new ObservableCollection<Models.NewsItem>();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (financialBoxItem.IsSelected)
            {
                NewsItemsManager.getNewsByFilteredResults("Financial", NewsItem);
                titleTextBlock.Text = "Financial";
            }
            else if (foodBoxItem.IsSelected)
            {
                NewsItemsManager.getNewsByFilteredResults("Food", NewsItem);
                titleTextBlock.Text = "Food";
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            financialBoxItem.IsSelected = true;
        }
    }
}

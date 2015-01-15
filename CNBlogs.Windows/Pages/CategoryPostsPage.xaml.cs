﻿using CNBlogs.Common;
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
using CNBlogs.DataHelper.CloudAPI;
using CNBlogs.DataHelper.DataModel;
using CNBlogs.DataHelper.Function;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace CNBlogs.Pages
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class CategoryPostsPage : FlatNavigationPage
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        Category category = null;
        private CategoryPostDS categoryDS = null;

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public CategoryPostsPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private async void LoadData()
        {
            //For favorite button display
            await FavoriteCategoryDS.Instance.Refresh();

            this.DataContext = null;
            this.categoryDS = new CategoryPostDS(category);
            this.categoryDS.OnLoadMoreStarted += TitleControl.DS_OnLoadMoreStarted;
            this.categoryDS.OnLoadMoreCompleted += TitleControl.DS_OnLoadMoreCompleted;
            this.gv_CategoryPosts.ItemsSource = this.categoryDS;
            this.gv_SimplePosts.ItemsSource = this.categoryDS;
            await this.categoryDS.Refresh();
            this.DataContext = this.categoryDS;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// 
        Windows.ApplicationModel.Resources.ResourceLoader loader = new Windows.ApplicationModel.Resources.ResourceLoader();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
            if (e.NavigationMode == NavigationMode.New)
            {
                Logger.LogAgent.GetInstance().WriteLog(this.GetType().ToString());
            }
            this.category = e.Parameter as Category;
            //change the topic
            this.TitleControl.Text = loader.GetString("CategoryTitleText") + " - " + category.Name;
            this.LoadData();
        }

        private void UpdateUI()
        {
            if(FavoriteCategoryDS.Instance.Items.Any(i => i.Item.Id == category.Id))
            {
                this.btn_Favorite.Visibility = Visibility.Collapsed;
                this.btn_UnFavorite.Visibility = Visibility.Visible;
            }
            else
            {
                this.btn_Favorite.Visibility = Visibility.Visible;
                this.btn_UnFavorite.Visibility = Visibility.Collapsed;
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private async void btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            if (sz_CategoryPosts.IsZoomedInViewActive)
            {
                if (this.categoryDS != null)
                {
                    TitleControl.DS_OnLoadMoreStarted(0);
                    await this.categoryDS.Refresh();
                    TitleControl.DS_OnLoadMoreCompleted(0);
                }
            }
        }

        private void btn_ScrollToTop_Click(object sender, RoutedEventArgs e)
        {
            if (sz_CategoryPosts.IsZoomedInViewActive)
                FunctionHelper.Functions.GridViewScrollToTop(this.gv_CategoryPosts);
            else
                FunctionHelper.Functions.GridViewScrollToTop(this.gv_SimplePosts);
        }

        private bool isZoomOutTapped = false;

        private void sz_CategoryPosts_ViewChangeStarted(object sender, SemanticZoomViewChangedEventArgs e)
        {
            e.DestinationItem.Item = e.SourceItem.Item;
        }

        private void sz_CategoryPosts_ViewChangeCompleted(object sender, SemanticZoomViewChangedEventArgs e)
        {
            if (!e.IsSourceZoomedInView & isZoomOutTapped)
            {
                Post post = e.DestinationItem.Item as Post;
                isZoomOutTapped = false;
                this.Frame.Navigate(typeof(PostReadingPage), post);
                sz_CategoryPosts.ToggleActiveView();
            }
        }

        private void gv_SimplePosts_Tapped(object sender, TappedRoutedEventArgs e)
        {
            isZoomOutTapped = true;
        }

        private void btn_ZoomChange_Click(object sender, RoutedEventArgs e)
        {
            sz_CategoryPosts.ToggleActiveView();
        }

        private void PostControl_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                PostControl postControl = sender as PostControl;
                postControl.ShowStoryBoard();
            }
            catch (Exception)
            {
            }
        }

        private void gv_CategoryPosts_ItemClick(object sender, ItemClickEventArgs e)
        {
            Post post = e.ClickedItem as Post;
            this.Frame.Navigate(typeof(PostReadingPage), post);
        }

        private async void btn_Favorite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var latestPostId = "";
                if (this.categoryDS.Count > 0)
                {
                    latestPostId = this.categoryDS.First().ID;
                }

                await FavoriteCategoryDS.Instance.Follow(this.category, latestPostId);

                notifyBlock.ShowMessage(loader.GetString("Notify_FavoriteCategory"));
                UpdateUI();
            }
            catch (Exception)
            {
            }
        }

        private async void btn_UnFavorite_Click(object sender, RoutedEventArgs e)
        {
            await FavoriteCategoryDS.Instance.Remove(new FavoriteItem<Category>() { Item = this.category });
            notifyBlock.ShowMessage(loader.GetString("Notify_UnFavoriteCategory"));
            UpdateUI();
        }

        private void CommandBar_Opened(object sender, object e)
        {
            this.UpdateUI();
        }
    }
}

﻿

#pragma checksum "E:\wp\CNBlogs\CNBlogs.Windows\Pages\CategoryPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4FBA8F8EDE5CB0D034297FEB3F0248F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNBlogs.Pages
{
    partial class CategoryPage : global::CNBlogs.FlatNavigationPage
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::CNBlogs.FlatNavigationPage pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource SubCategories; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource Categories; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::CNBlogs.PageTitleControl TitleControl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.SemanticZoom sz_Category; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.GridView gv_Category; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.GridView gv_SubCategory; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_ScrollToTop; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_ZoomChange; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Pages/CategoryPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::CNBlogs.FlatNavigationPage)this.FindName("pageRoot");
            SubCategories = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("SubCategories");
            Categories = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("Categories");
            TitleControl = (global::CNBlogs.PageTitleControl)this.FindName("TitleControl");
            sz_Category = (global::Windows.UI.Xaml.Controls.SemanticZoom)this.FindName("sz_Category");
            gv_Category = (global::Windows.UI.Xaml.Controls.GridView)this.FindName("gv_Category");
            gv_SubCategory = (global::Windows.UI.Xaml.Controls.GridView)this.FindName("gv_SubCategory");
            btn_ScrollToTop = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_ScrollToTop");
            btn_ZoomChange = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_ZoomChange");
        }
    }
}




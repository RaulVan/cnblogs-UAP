﻿

#pragma checksum "E:\wp\CNBlogs\CNBlogs.WindowsPhone\Views\BloggerPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4FF4556284AEF23A7AA3045BEA4AE12"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNBlogs
{
    partial class BloggerPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard sb_AuthorMoveUp; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard sb_AuthorMoveDown; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard sb_CountMoveOut; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard sb_CountMoveIn; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ProgressBar pb_Top; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock tb_PostCount; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView lv_AuthorPosts; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Border border_AuthorControl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::CNBlogs.AuthorControl authorControl1; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btn_Homepage; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Border border_Text; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Border border_Author; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::CNBlogs.AuthorControl authorControl0; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.CommandBar cmdBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_ScrollToTop; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_focus; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_NightMode; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton btn_Setting; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Views/BloggerPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            sb_AuthorMoveUp = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("sb_AuthorMoveUp");
            sb_AuthorMoveDown = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("sb_AuthorMoveDown");
            sb_CountMoveOut = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("sb_CountMoveOut");
            sb_CountMoveIn = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("sb_CountMoveIn");
            pb_Top = (global::Windows.UI.Xaml.Controls.ProgressBar)this.FindName("pb_Top");
            tb_PostCount = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("tb_PostCount");
            lv_AuthorPosts = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("lv_AuthorPosts");
            border_AuthorControl = (global::Windows.UI.Xaml.Controls.Border)this.FindName("border_AuthorControl");
            authorControl1 = (global::CNBlogs.AuthorControl)this.FindName("authorControl1");
            btn_Homepage = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btn_Homepage");
            border_Text = (global::Windows.UI.Xaml.Controls.Border)this.FindName("border_Text");
            border_Author = (global::Windows.UI.Xaml.Controls.Border)this.FindName("border_Author");
            authorControl0 = (global::CNBlogs.AuthorControl)this.FindName("authorControl0");
            cmdBar = (global::Windows.UI.Xaml.Controls.CommandBar)this.FindName("cmdBar");
            btn_ScrollToTop = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_ScrollToTop");
            btn_focus = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_focus");
            btn_NightMode = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_NightMode");
            btn_Setting = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("btn_Setting");
        }
    }
}




﻿#pragma checksum "..\..\..\PresentationLayer\GameSessionView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6BE2FE1D5D0BBE2285A5863545ECCA75CC8D992"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfTheAionProject.PresentationLayer;


namespace WpfTheAionProject.PresentationLayer {
    
    
    /// <summary>
    /// GameSessionView
    /// </summary>
    public partial class GameSessionView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 251 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl LocationInfoTabControl;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem ItemsInfoTabItem;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid LocationItemsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 315 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid InventoryDataGrid;
        
        #line default
        #line hidden
        
        
        #line 418 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QuitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TBQuestGame.S3;component/presentationlayer/gamesessionview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PresentationLayer\GameSessionView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 189 "..\..\..\PresentationLayer\GameSessionView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NorthTravelButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 203 "..\..\..\PresentationLayer\GameSessionView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EastTravelButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 217 "..\..\..\PresentationLayer\GameSessionView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SouthTravelButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 231 "..\..\..\PresentationLayer\GameSessionView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WestTravelButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LocationInfoTabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 6:
            this.ItemsInfoTabItem = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.LocationItemsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            
            #line 283 "..\..\..\PresentationLayer\GameSessionView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PickUpButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.InventoryDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            
            #line 338 "..\..\..\PresentationLayer\GameSessionView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UseButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.QuitButton = ((System.Windows.Controls.Button)(target));
            
            #line 422 "..\..\..\PresentationLayer\GameSessionView.xaml"
            this.QuitButton.Click += new System.Windows.RoutedEventHandler(this.QuitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


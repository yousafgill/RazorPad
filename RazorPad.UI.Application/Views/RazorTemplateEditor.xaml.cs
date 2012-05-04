﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using RazorPad.ViewModels;
using TextBox = System.Windows.Controls.TextBox;
using UserControl = System.Windows.Controls.UserControl;

namespace RazorPad.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RazorTemplateEditor : UserControl
    {

        protected RazorTemplateEditorViewModel ViewModel
        {
            get { return (RazorTemplateEditorViewModel) DataContext; }
        }

        public RazorTemplateEditor()
        {
            InitializeComponent();
        }
    }
}

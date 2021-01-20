﻿using System.Windows.Input;
using Telerik.XamarinForms.RichTextEditor;
using Xamarin.Forms;

namespace SDKBrowser.Examples.RichTextEditorControl.FeaturesCategory.CustomContextMenuExample
{
    // >> richtexteditor-contextmenu-vm
    public class ViewModel
    {
        public ViewModel()
        {
            this.CustomInfoCommand = new Command(this.CustomInfoCommandExecute);
        }

        private void CustomInfoCommandExecute(object param)
        {
            var selectionRange = (RichTextSelectionRange) param;
            Application.Current.MainPage.DisplayAlert("Info", string.Format("Selection starts at {0} to {1} position.", selectionRange.Start, selectionRange.End), "Ok");
        }

        public ICommand CustomInfoCommand { get; set; }
    }
    // << richtexteditor-contextmenu-vm
}

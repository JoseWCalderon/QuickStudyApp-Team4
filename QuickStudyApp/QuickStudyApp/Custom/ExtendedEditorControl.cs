using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QuickStudyApp.Custom
{
    // this is a custom change to the editor in XAML to allow for it to expand

    //inherit the editor class
    public class ExtendedEditorControl: Editor
    {
        //constructor
        public ExtendedEditorControl()
        {
            TextChanged += OnTextChanged;
        }
        
        //turn off the control
        ~ExtendedEditorControl()
        {
            TextChanged -= OnTextChanged;
        }

        //event trigger event
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            InvalidateMeasure();
        }
    }
}

using QuickStudyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuickStudyApp.Controls
{
    public class FAQSearchHandler : SearchHandler
    {
        public IList<FAQ> FAQs { get; set; }

        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = FAQs
                    .Where(faq => faq.Question.ToLower().Contains(newValue.ToLower())).ToList<FAQ>();
            }
        }
        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
            await Shell.Current.GoToAsync($"{GetNavigationTarget()}?question{((FAQ)item).Question}");
        }

        string GetNavigationTarget()
        {
            return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;
        }
    }
}

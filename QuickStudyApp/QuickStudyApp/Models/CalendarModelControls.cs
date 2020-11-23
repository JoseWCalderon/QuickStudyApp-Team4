using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using QuickStudyApp.Services;

namespace QuickStudyApp.Models
{
    public class CalendarModelControl
    {

    }
    //{
    //    public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
    //    string title = string.Empty;
    //    bool isBusy = false;
    //    public bool IsBusy
    //    {
    //        get { return isBusy; }
    //        set { SetProperty(ref isBusy, value); }
    //    }
    //    public string Title
    //    {
    //        get { return title; }
    //        set { SetProperty(ref title, value); }
    //    }
    //    protected bool SetProperty<T>(ref T backingStore, T value,
    //[CallerMemberName] string propertyName = "",
    //Action onChanged = null)
    //    {
    //        if (EqualityComparer<T>.Default.Equals(backingStore, value))
    //            return false;

    //        backingStore = value;
    //        onChanged?.Invoke();
    //        OnPropertyChanged(propertyName);
    //        return true;
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    //    {
    //        var changed = PropertyChanged;
    //        if (changed == null)
    //            return;

    //        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    
}
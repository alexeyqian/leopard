﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Leopard.ViewModels;
using Xamarin.Forms;

namespace Leopard.Services
{
    public class NavigationService : INavigationService
    {
        private Dictionary<string, Type> pages { get; } = new Dictionary<string, Type>();

        public Page MainPage => Application.Current.MainPage;

        public void Configure(string key, Type pageType) => pages[key] = pageType;

        public void GoBack() => MainPage.Navigation.PopAsync();

        public void NavigateTo(string pageKey, object parameter = null)
        {
            if(pages.TryGetValue(pageKey, out Type pageType))
            {
                var page = (Page)Activator.CreateInstance(pageType);
                page.SetNavigationArgs(parameter);
                MainPage.Navigation.PushAsync(page);
                (page.BindingContext as BaseViewModel).InitializeAsync(parameter);
            }else
            {
                throw new ArgumentException($"Page doesn't exist: {pageKey}", nameof(pageKey));
            }
        }
    }

    public static class NavigationExtensions
    {
        private static ConditionalWeakTable<Page, object> arguments = new ConditionalWeakTable<Page, object>();

        public static object GetNavigationArgs(this Page page)
        {
            object argument;
            arguments.TryGetValue(page, out argument);
            return argument;
        }

        public static void SetNavigationArgs(this Page page, object args) => arguments.Add(page, args);
    }
}

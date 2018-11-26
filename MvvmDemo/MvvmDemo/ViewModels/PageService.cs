using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmDemo.ViewModels
{
    class PageService : IPageService
    {
        private readonly Page page;

        public PageService()
        {
            page = Application.Current.MainPage;
        }

        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return await page.DisplayAlert(title, message, ok, cancel);
        }

        public async Task PushAsync(Page page)
        {
            await page.Navigation.PushAsync(page);
        }
    }
}

using Microsoft.WindowsAzure.MobileServices;
using PackingList.Models;
using PackingList.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace PackingList.ViewModels
{
    public class MainViewModel
    {
        public MobileServiceCollection<Reis, Reis> reizen;
        public IMobileServiceTable<Reis> reisTable;

        public MainViewModel()
        {
            reisTable = App.MobileService.GetTable<Reis>(); 
        }


        public async Task<MobileServiceCollection<Reis, Reis>> GetReizen()
        {
            try
            {
                reizen = await reisTable
                    .Where(t => t.Title == App.gebruiker.Id)
                    .ToCollectionAsync();
            }
            catch (MobileServiceInvalidOperationException e)
            {
                await new MessageDialog(e.Message, "Error reizen").ShowAsync();
            }
            return reizen;
        }

        public async Task InsertReis(Reis reis)
        {

            App.gebruiker.Trips.Add(reis);
            await reisTable.InsertAsync(reis);

        }
    }
}

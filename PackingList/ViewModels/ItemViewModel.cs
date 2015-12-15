using Microsoft.WindowsAzure.MobileServices;
using PackingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace PackingList.ViewModels
{
    class ItemViewModel
    {
        private MobileServiceCollection<ReisItem, ReisItem> items;
        public IMobileServiceTable<ReisItem> ItemTable { get; set; }

        private Reis currentReis;

        public ItemViewModel(Reis reis)
        {
            currentReis = reis;
            ItemTable = App.MobileService.GetTable<ReisItem>();

        }

        public async Task<MobileServiceCollection<ReisItem, ReisItem>> GetItems(Reis reis)
        {
            try
            {
                items = await ItemTable.
                   Where(i => i.Title == reis.Title).
                   ToCollectionAsync();

            }
            catch (MobileServiceInvalidOperationException e)
            {

                await new MessageDialog(e.Message, "Error failed loading items").ShowAsync();
            }

            return items;

        }

        /*public async Task UpdateItem(ReisItem item)
        {
            System.Diagnostics.Debug.WriteLine(item.AmountDone);
            await ItemTable.UpdateAsync(item);
        }*/


        public async Task AddItem(ReisItem item)
        {
            //TODO
            items = await GetItems(currentReis);
            await ItemTable.InsertAsync(item);
            items.Add(item);
        }
    }
}

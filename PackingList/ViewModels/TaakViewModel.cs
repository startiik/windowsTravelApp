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
    class TaakViewModel
    {
        private MobileServiceCollection<Taak, Taak> taken;
        public IMobileServiceTable<Taak> TaskTable { get; set; }
        private Reis currentReis;
        public TaakViewModel(Reis reis)
        {
            TaskTable = App.MobileService.GetTable<Taak>();
            currentReis = reis;
        }


        public async Task<MobileServiceCollection<Taak, Taak>> GetTasks(Reis reis)
        {
            try
            {
                taken = await TaskTable.
                    Where(t => t.Title == reis.Title).
                    ToCollectionAsync();
            }
            catch (MobileServiceInvalidOperationException e)
            {
                await new MessageDialog(e.Message, "Error failed loading").ShowAsync();
            }

            return taken;
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using TravelBBNService.DataObjects;
using TravelBBNService.Models;

namespace TravelBBNService.Controllers
{
    public class ReisController : TableController<Reis>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            TravelBBNContext context = new TravelBBNContext();
            DomainManager = new EntityDomainManager<Reis>(context, Request, Services);
        }

        // GET tables/Reis
        public IQueryable<Reis> GetAllReis()
        {
            return Query(); 
        }

        public IQueryable<Reis> GetAllReisUser(string user)
        {
            return GetAllReis().Where(UserID => UserID.Equals(user));
        }

        // GET tables/Reis/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Reis> GetReis(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Reis/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Reis> PatchReis(string id, Delta<Reis> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Reis
        public async Task<IHttpActionResult> PostReis(Reis item)
        {
            Reis current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Reis/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteReis(string id)
        {
             return DeleteAsync(id);
        }

    }
}
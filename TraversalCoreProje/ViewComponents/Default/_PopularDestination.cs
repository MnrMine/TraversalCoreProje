using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;


namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestination : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}

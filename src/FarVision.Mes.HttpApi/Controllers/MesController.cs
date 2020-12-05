using FarVision.Mes.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FarVision.Mes.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MesController : AbpController
    {
        protected MesController()
        {
            LocalizationResource = typeof(MesResource);
        }
    }
}
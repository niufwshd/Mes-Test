using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FarVision.Mes.Web
{
    [Dependency(ReplaceServices = true)]
    public class MesBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Mes";
    }
}

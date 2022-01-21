using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DataManagement;

[Dependency(ReplaceServices = true)]
public class DataManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DataManagement";
}

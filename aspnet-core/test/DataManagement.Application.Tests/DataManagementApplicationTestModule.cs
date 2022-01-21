using Volo.Abp.Modularity;

namespace DataManagement;

[DependsOn(
    typeof(DataManagementApplicationModule),
    typeof(DataManagementDomainTestModule)
    )]
public class DataManagementApplicationTestModule : AbpModule
{

}

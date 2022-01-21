using DataManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DataManagement;

[DependsOn(
    typeof(DataManagementEntityFrameworkCoreTestModule)
    )]
public class DataManagementDomainTestModule : AbpModule
{

}

using DataManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DataManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DataManagementController : AbpControllerBase
{
    protected DataManagementController()
    {
        LocalizationResource = typeof(DataManagementResource);
    }
}

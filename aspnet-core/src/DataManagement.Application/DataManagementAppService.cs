using System;
using System.Collections.Generic;
using System.Text;
using DataManagement.Localization;
using Volo.Abp.Application.Services;

namespace DataManagement;

/* Inherit your application services from this class.
 */
public abstract class DataManagementAppService : ApplicationService
{
    protected DataManagementAppService()
    {
        LocalizationResource = typeof(DataManagementResource);
    }
}

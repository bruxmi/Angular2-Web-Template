using Core.Entities.Application;
using Core.Interfaces.Repository.Query;
using Core.Interfaces.Services.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ApplicationSettings
{
    public class ApplicationSettingQueryService : IApplicationSettingQueryService
    {
        private readonly IApplicationSettingsQueryRepository<ApplicationSetting> settingsRepository;

        public ApplicationSettingQueryService(IApplicationSettingsQueryRepository<ApplicationSetting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public async Task<List<ApplicationSetting>> GetAllApplicationSettingsAsync()
        {
            return await this.settingsRepository.GetAllAsync();
        }
    }
}

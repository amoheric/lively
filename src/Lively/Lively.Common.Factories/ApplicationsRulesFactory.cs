﻿using Lively.Models;
using System.IO;

namespace Lively.Common.Factories
{
    public class ApplicationsRulesFactory : IApplicationsRulesFactory
    {
        public ApplicationRulesModel CreateAppPauseRule(string appPath, AppRulesEnum rule)
        {
            var fileName = Path.GetFileNameWithoutExtension(appPath);
            return new ApplicationRulesModel(fileName, rule);
        }

        public AppMusicExclusionRuleModel CreateAppMusicExclusionRule(string appPath)
        {
            var fileName = Path.GetFileNameWithoutExtension(appPath);
            return new AppMusicExclusionRuleModel(fileName, appPath);
        }
    }
}

using Lab.Game.WinningStreak.BLL;
using Lab.Game.WinningStreak.BLL.Dice;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Lab.Game.WinningStreak.Client
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IDie, Die>();
            container.RegisterType<IWinningStreakProcessor, WinningStreakProcessor>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;

namespace AopInDotNet.CastleWindsor
{
    [TestClass]
    public class SimpleInjectTest
    {
        [TestMethod]
        public void FromAssembly()
        {
            var container = new WindsorContainer();

            container.Install(new RepositoriesInstaller(), new LoggerInstaller());

            var king = container.Resolve<IKing>();
            king.RuleTheCastle();
        }
    }

    public class RepositoriesInstaller 
        : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes
                .FromThisAssembly()
                .Where(Component.IsInSameNamespaceAs<King>())
                .WithService.DefaultInterfaces()
                .LifestyleTransient());
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopInDotNet.MovieStore
{
    using Castle.Windsor;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;

    public class MovieStoreInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IMovieFinder>().ImplementedBy<SimpleMovieFinder>(),
                Component.For<MovieLister>());
        }
    }
}
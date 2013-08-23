using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;

using AopInDotNet.Dto;
using AopInDotNet.Auction;
using System.Diagnostics;
using Castle.DynamicProxy;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Facilities.TypedFactory;
using Castle.Windsor;
using Castle.Core;
<<<<<<< HEAD
using Castle.Core.Logging;
=======
using AopInDotNet.MovieStore;
>>>>>>> b7c814a5fc8bbec6bae73c3d245814843e506439

namespace AopInDotNet
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            Mapper.CreateMap<Member, MemberDto>();
            Mapper.CreateMap<MemberDto, Member>()
                .ForMember( m => m.Version, opt => opt.Ignore() );

            Mapper.AssertConfigurationIsValid();
        }

        [TestMethod]
        public void Flattening()
        {
            var memer = new Member
            {
                LoginName = "5555",
                ReputationPoints = "6666",
            };

            var dto = Mapper.Map<Member, MemberDto>(memer);
        }

        [TestMethod]
        public void RunHello()
        {
            using (var container = new WindsorContainer().Install(new Installer()))
            {
                for (int i = 0; i < 5; i++)
                {
                    var myClass = container.Resolve<IMyClass>();
                    myClass.MyMethod();
                }
            }
        }

<<<<<<< HEAD
        [TestMethod]
        public void MyLazy()
        {
            
            using (var container = new WindsorContainer().Install(new Installer()))
            {
                
                var myLazy = container.Resolve<IMyLazy>();

                myLazy.MyClass.MyMethod();
=======

        [TestMethod]
        public void TestCodeBasedCastleWindsorDI()
        {
            using (var container = new WindsorContainer())
            {
                container.Install(new MovieStoreInstaller());

                var aMovieLister = container.Resolve<MovieLister>();

                var movie = aMovieLister.MoviesDirectedBy("Director10").Single();

                Console.WriteLine("Title:{0}, Director:{1}", movie.Title, movie.Director);
>>>>>>> b7c814a5fc8bbec6bae73c3d245814843e506439
            }
        }

        public IMyClass GetMyClass()
        {
            var proxyGenerator = new ProxyGenerator();

            var myClass = proxyGenerator.CreateInterfaceProxyWithTargetInterface<IMyClass>(
                new MyClass { Name = "ChavP" },
                new MyInterceptorErrorAspect(),
                new MyInterceptorAspect());

            return myClass;
        }
    }

    public class MyClass : IMyClass
    {
        Guid id = Guid.NewGuid();
        public virtual string Name { get; set; }

        public bool MyMethod()
        {
            Console.WriteLine("Hello, world! - " + id.ToString());
            return true;
        }

        public bool MyMethod2()
        {
            Console.WriteLine("Begin, MyMethod2");
            throw new Exception("Error");
            Console.WriteLine("End");
            return true;
        }
    }

    public interface IMyClass
    {
        bool MyMethod();
        bool MyMethod2();
    }

    public interface IMyLazy
    {
        IMyClass MyClass { get; }
    }

    public class MyLazy : IMyLazy
    {
        private IMyClass _IMyClass;

        public MyLazy(IMyClass iMyClass)
        {
            _IMyClass = iMyClass;
        }

        public IMyClass MyClass { get { return _IMyClass; } }
        
    }

    public class MyInterceptorAspect : IInterceptor
    {
        Guid id = Guid.NewGuid();
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before " + invocation.Method.Name);
            var m = invocation.InvocationTarget as MyClass;
            Console.WriteLine(id.ToString());
            invocation.Proceed();
            Console.WriteLine("After " + invocation.Method.Name);
        }
    }

    public class MyInterceptorErrorAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Log Error");
                throw ex;
            }
        }
    }

    public class MyInterceptorTaskAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var task = new Task(invocation.Proceed);
            task.Start();
        }
    }

    public class Installer : IWindsorInstaller
    {

        #region IWindsorInstaller Members

        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                Component
                .For<MyInterceptorAspect>()
                .LifeStyle.PerThread,

                Component
                .For<IMyClass>()
                .ImplementedBy<MyClass>()
                .Interceptors<MyInterceptorAspect>()
                .LifeStyle.Transient,
                
                Component
                .For<IMyLazy>()
                .ImplementedBy<MyLazy>()
                .LifeStyle.Transient

                );
        }

        #endregion
    }
}

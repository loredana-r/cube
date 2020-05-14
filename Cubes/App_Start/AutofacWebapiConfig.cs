using Autofac;
using Autofac.Integration.WebApi;
using Cubes.Services;
using System.Reflection;
using System.Web.Http;

namespace Cubes.App_Start
{
	public class AutofacWebapiConfig
	{
		public static IContainer Container;

		public static void Initialize(HttpConfiguration config)
		{
			Initialize(config, RegisterServices(new ContainerBuilder()));
		}

		public static void Initialize(HttpConfiguration config, IContainer container)
		{
			config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
		}

		private static IContainer RegisterServices(ContainerBuilder builder)
		{
			builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

			builder.RegisterType<CubeService>()
				.AsImplementedInterfaces()
				.InstancePerRequest();

			Container = builder.Build();

			return Container;
		}
	}
}
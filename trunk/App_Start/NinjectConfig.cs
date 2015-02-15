using System;
using System.Reflection;
using Ninject;
using WepApiOwinNinject.Interfaces;
using WepApiOwinNinject.Services;

namespace WepApiOwinNinject
{
	public static class NinjectConfig
	{
		public static Lazy<IKernel> CreateKernel = new Lazy<IKernel>(() =>
		{
			var kernel = new StandardKernel();
			kernel.Load(Assembly.GetExecutingAssembly());

			RegisterServices(kernel);

			return kernel;
		});

		private static void RegisterServices(KernelBase kernel)
		{
			kernel.Bind<IFakeService>()
			 .To<FakeService>();
		}
	}
}
using System.Web.Mvc;
using Abarrotes.DAL;
using Abarrotes.BAL;
using Abarrotes.Controllers;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace Abarrotes
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            container.RegisterType<IProductosBo, ProductosBo>();
            container.RegisterType<IProductosDao, ProductosDao>();
            container.RegisterType<IUsuariosBo, UsuariosBo>();
            container.RegisterType<IUsuariosDao, UsuariosDao>();
            container.RegisterType<IController, ProductosController>("Productos");
            container.RegisterType<IController, UsuariosController>("Usuarios");
            RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}
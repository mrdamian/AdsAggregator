using Castle.MicroKernel.Registration;
using System;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using AdsAggregatorWebPresentationModel.Controllers;
using System.Web.Mvc;
using System.Configuration;

namespace AdsAggregatorWeb
{
    public class AdsAggregatorWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
           container.Register(Classes
                .FromAssemblyContaining<HomeController>()
                .BasedOn<IController>().LifestylePerWebRequest());
            var dataAccessAssemblyName = ConfigurationManager.AppSettings["dataAccessAssemblyName"];
            string connectionString = ConfigurationManager.ConnectionStrings["AdsAggregatorDb"].ConnectionString;
            container.Register(Classes
                .FromAssemblyNamed(dataAccessAssemblyName)
                .Where(t => t.Name.EndsWith("Repository"))
                .WithService
                .FirstInterface()
                .Configure(r => r.LifeStyle.PerWebRequest
                    .DependsOn((new
                    {
                        connString = connectionString
                    }))));
        }
    }
}
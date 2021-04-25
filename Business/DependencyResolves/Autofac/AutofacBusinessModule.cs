using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataBase.Abstract;
using DataBase.Concrete.EntittyFaremwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RentalManager>().As<IRentalsService>().SingleInstance();
            builder.RegisterType<EfRentalDal>().As<IRentalDal>().SingleInstance();
        }
    }
}

 

using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace WY.RMS.Component.Tools.helpers
{
    public class AutofacHelper : IAutofacHelper
    {
        public T GetByName<T>(string name)
        {
            return AutofacDependencyResolver.Current.RequestLifetimeScope.ResolveNamed<T>(name);
        }
    }


}

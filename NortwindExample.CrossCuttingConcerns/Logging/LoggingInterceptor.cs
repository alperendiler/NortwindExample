using Ninject.Extensions.Interception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortwindExample.CrossCuttingConcerns.Logging
{
    public class LoggingInterceptor:SimpleInterceptor
    {
        protected override void BeforeInvoke(IInvocation invocation)
        {
            //loglama framwork'ünün loglama işlemlerini yapılacak
            //invocation.Request.Method.Name
            base.BeforeInvoke(invocation);
        }

        protected override void AfterInvoke(IInvocation invocation)
        {
            base.AfterInvoke(invocation);
        }
    }
}

using News.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.ManagementServices
{
    public class BaseManagementService
    {
        protected readonly NewsDBContext _newsDBContext = new NewsDBContext();
    }
}

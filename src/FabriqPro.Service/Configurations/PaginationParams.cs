using FabriqPro.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabriqPro.Service.Configurations;


public class PaginationParams
{
    public PaginationParams()
    {
        PageIndex = EnvironmentHelper.PageIndex;
        PageSize = EnvironmentHelper.PageSize;
    }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
}
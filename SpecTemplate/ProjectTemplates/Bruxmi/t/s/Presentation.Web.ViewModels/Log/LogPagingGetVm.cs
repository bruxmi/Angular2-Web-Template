using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Web.ViewModels.Log
{
    public class LogPagingGetVm
    {
        public LogPagingGetVm()
        {
            this.Logs = new List<LogGetVm>();
        }
        public int Count { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string SearchTerm { get; set; }
        public bool IsDescending { get; set; }
        public List<LogGetVm> Logs { get; set; }
    }
}

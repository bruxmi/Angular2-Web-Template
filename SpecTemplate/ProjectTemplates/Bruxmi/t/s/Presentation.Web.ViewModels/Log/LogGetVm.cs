using System;

namespace Presentation.Web.ViewModels.Log
{
    public class LogGetVm
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public string Exception { get; set; }

        public string Level { get; set; }

        public string RequestId { get; set; }

        public string UserName { get; set; }
    }
}

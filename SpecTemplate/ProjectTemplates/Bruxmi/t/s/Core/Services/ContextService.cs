using Core.Constants;
using Core.Interfaces.Services.Query;
using System.Web;

namespace Core.Services
{
    public class ContextService : IContextService
    {
        private string requestId;

        public string RequestId
        {
            get
            {
                return this.requestId ?? string.Empty;
            }
            set
            {
                this.requestId = value;

                if (HttpContext.Current != null)
                {
                    HttpContext.Current.Items.Add(HttpContextItems.REQUEST_ID, this.requestId);
                }
            }
        }
    }
}

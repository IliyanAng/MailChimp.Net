using MailChimp.Net.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Interfaces
{
    public interface IConnectedWebsitesLogic
    {
        Task<ConnectedWebsiteResponse> GetConnectedWebsiteAsync();
        Task<CreateConnectedWebsiteResponse> CreateConnectedWebsiteAsync(string foreignId, string domain);
    }
}

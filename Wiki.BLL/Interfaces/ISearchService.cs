using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wiki.BLL.Model;

namespace Wiki.BLL.Interfaces
{
    public interface ISearchService
    {
        Task<List<SearchResult>> SearchEntitiesAsync(string searchKey, string language = "en");
    }
}

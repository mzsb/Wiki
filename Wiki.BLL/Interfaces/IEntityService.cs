using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wiki.BLL.Model;
using Wiki.BLL.Model.ClaimData;
using Wiki.BLL.Model.Entity;

namespace Wiki.BLL.Interfaces
{
    public interface IEntityService
    {
        Task<Entity> GetByIdAsync(string id, List<string> languages = null);

        Task<Dictionary<IClaimData, List<IClaimData>>> LoadClaimsAsync(Entity entity, List<string> languages = null);
    }
}

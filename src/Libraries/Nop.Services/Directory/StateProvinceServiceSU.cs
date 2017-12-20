using Nop.Core.Domain.Directory;
using System.Linq;

namespace Nop.Services.Directory
{
    public partial class StateProvinceService : IStateProvinceService
    {
        /// <summary>
        /// Gets a state/province by country identifier
        /// </summary>
        /// <param name="countryId">Country identifier</param>/// 
        /// <param name="abbreviation">The state/province abbreviation</param>
        /// <returns>State/province</returns>
        public StateProvince GetStateProvinceByAbbreviation(int countryId, string abbreviation)
        {
            var query = from sp in _stateProvinceRepository.Table
                        where sp.Abbreviation == abbreviation 
                            && sp.CountryId == countryId
                        select sp;
            var stateProvince = query.FirstOrDefault();
            return stateProvince;
        }
    }
}

using Nop.Core.Domain.Directory;

namespace Nop.Services.Directory
{
    public partial interface IStateProvinceService
    {
        /// <summary>
        /// Gets a state/province by country identifier
        /// </summary>
        /// <param name="countryId">Country identifier</param>/// 
        /// <param name="abbreviation">The state/province abbreviation</param>
        /// <returns>State/province</returns>
        StateProvince GetStateProvinceByAbbreviation(int countryId, string abbreviation);
    }
}

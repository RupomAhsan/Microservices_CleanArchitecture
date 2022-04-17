using Ardalis.Specification;
using CleanArchitecture.Domain.Entity.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Lookups.Specifications
{
    public class LookupDetailByNameAndTypeSpec : Specification<LookupDetailEntity>, ISingleResultSpecification
    {
        public LookupDetailByNameAndTypeSpec(string lookupMasterType, string lookupdetailName)
        {
            Query
                .Where(lookupdetail => lookupdetail.Name == lookupdetailName && lookupdetail.LookupMaster.Type == lookupMasterType);
                //.Include(lookupMaster => lookupMaster.LookupMaster);
        }
    }
}

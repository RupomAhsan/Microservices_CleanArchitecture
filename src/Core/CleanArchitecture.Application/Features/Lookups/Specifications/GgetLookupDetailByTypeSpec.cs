using Ardalis.Specification;
using CleanArchitecture.Domain.Entity.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Lookups.Specifications
{
    public class GgetLookupDetailByTypeSpec : Specification<LookupDetailEntity>, ISingleResultSpecification
    {
        public GgetLookupDetailByTypeSpec(string lookupMasterType)
        {
            Query
                .Where(lookupdetail => lookupdetail.LookupMaster.Type == lookupMasterType && lookupdetail.IsActive==true && lookupdetail.IsDeleted==false);
            //.Include(lookupMaster => lookupMaster.LookupMaster);
        }
    }
}

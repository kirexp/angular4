using ESA.DAL.Almaty.Entities.DayCareService;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.DayCareService {
    public class DayCareFreePlaceOverride : IAutoMappingOverride<DayCareFreePlace> {
        public void Override(AutoMapping<DayCareFreePlace> mapping) {
            mapping.References(x => x.DayCare).Not.Nullable().Cascade.All();
            mapping.Map(x => x.Year).Not.Nullable();
            mapping.Map(x => x.FreePlaceType).Not.Nullable();
            mapping.Map(x => x.Language).Not.Nullable().Default("'0'");
            mapping.Map(x => x.TotalCount).Not.Nullable().Default("'0'");
            mapping.Map(x => x.FreeCount).Not.Nullable().Default("'0'");
            mapping.Map(x => x.CreationDateTime).Not.Nullable().Default("'getdate()'");
            mapping.References(x => x.User).Not.Nullable().Cascade.All();
            mapping.Map(x => x.IsReserved).Default("'0'");
        }
    }
}

using ESA.DAL.Almaty.Entities.DayCareService;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.DayCareService {
    public class DayCareDirectionOverride : IAutoMappingOverride<DayCareDirection>
    {
        public void Override(AutoMapping<DayCareDirection> mapping) {
            mapping.References(x => x.DayCare).Not.Nullable().Cascade.All();
            mapping.Map(x => x.Number).Not.Nullable();
            mapping.Map(x => x.DateTime).Not.Nullable().Default("'getdate()'");
            mapping.References(x => x.DayCareFreePlace).Not.Nullable().Cascade.All();
            mapping.References(x => x.DayCareQueueRequest).Cascade.SaveUpdate();
            mapping.References(x => x.DirectionState).Not.Nullable().Cascade.All();
        }
    }
}

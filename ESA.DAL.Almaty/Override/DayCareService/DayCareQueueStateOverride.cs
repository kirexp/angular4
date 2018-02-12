using ESA.DAL.Almaty.Entities.DayCareService;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.DayCareService
{
    public class DayCareQueueStateOverride : IAutoMappingOverride<DayCareQueueState>
    {
        public void Override(AutoMapping<DayCareQueueState> mapping) {
            mapping.Map(x => x.StateInQueue).Nullable();
            mapping.Map(x => x.FirstCheckedDate).Nullable();
            mapping.Map(x => x.LastApprovalDate).Nullable();
            mapping.Map(x => x.WasBlocked).Not.Nullable().Default("'0'");
            mapping.Map(x => x.WasBlocked).Default("'0'");
            mapping.Map(x => x.BlockCount).Default("0");
            mapping.References(x => x.ActiveDirection).Nullable();
        }
    }
}

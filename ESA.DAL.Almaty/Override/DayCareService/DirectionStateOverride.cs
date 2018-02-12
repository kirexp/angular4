using ESA.DAL.Almaty.Entities.DayCareService;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.DayCareService
{
    public class DirectionStateOverride:IAutoMappingOverride<DirectionState>
    {
        public void Override(AutoMapping<DirectionState> mapping) {
            mapping.Map(x => x.LastChangeDate).Default("getdate()");
            mapping.Map(x => x.Reason).Length(5000);
        }
    }
}

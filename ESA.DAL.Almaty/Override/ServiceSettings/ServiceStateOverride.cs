using ESA.DAL.Almaty.Entities.ServiceSettings;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.ServiceSettings {
    public class ServiceStateOverride : IAutoMappingOverride<ServiceStep> {
        public void Override(AutoMapping<ServiceStep> mapping)
        {
            mapping.Map(x => x.Service).Not.Nullable();
            mapping.Map(x => x.Step).Not.Nullable().CustomType<int>();
            //mapping.Map(x => x.CurrentState).Not.Nullable().CustomType<int>();
            //mapping.Map(x => x.NextState).Not.Nullable().CustomType<int>();
            mapping.References(x=>x.Executor).Not.Nullable();
        }
    }
}
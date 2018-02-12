using ESA.DAL.Almaty.Entities.ServiceSettings;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.ServiceSettings {
    public class ServiceEmployeeOverride : IAutoMappingOverride<ServiceEmployee> {
        public void Override(AutoMapping<ServiceEmployee> mapping)
        {
            mapping.Map(x => x.Service).Not.Nullable();
            mapping.References(x=>x.Executor).Not.Nullable().Cascade.All();
        }
    }
}
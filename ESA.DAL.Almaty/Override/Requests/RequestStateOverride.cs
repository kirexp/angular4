using ESA.DAL.Almaty.Entities.Requests;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Requests {
    public class RequestStateOverride : IAutoMappingOverride<RequestState> {
        public void Override(AutoMapping<RequestState> mapping) {
            mapping.Map(x => x.Step).Not.Nullable();
            mapping.Map(x => x.State).Not.Nullable();
            mapping.Map(x => x.DateTime).Not.Nullable().Default("'getdate()'");
            mapping.References(x => x.User).Not.Nullable().Cascade.SaveUpdate();
            mapping.References(x => x.Request).Not.Nullable();
        }
    }
}
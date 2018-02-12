using ESA.DAL.Almaty.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override {
    public class PrivilagedPersonOverride : IAutoMappingOverride<PrivilagedPerson> {
        public void Override(AutoMapping<PrivilagedPerson> mapping) {
            mapping.Map(x => x.Iin).Not.Nullable().Length(12);
            mapping.Map(x => x.LastName).Not.Nullable();
            mapping.Map(x => x.FirstName).Not.Nullable();
            mapping.Map(x => x.BirthDate).Not.Nullable();
            mapping.Map(x => x.PrivilageType).Not.Nullable();
            mapping.Map(x => x.BeginDate).Not.Nullable();
            mapping.Map(x => x.ChangeDateTime).Not.Nullable().Default("'getdate()'");
            mapping.References(x => x.User).Not.Nullable();
        }
    }
}
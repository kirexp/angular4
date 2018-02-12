using ESA.DAL.Almaty.Entities.Account;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Account {
    public class ProfileOverride : IAutoMappingOverride<Profile> {
        public void Override(AutoMapping<Profile> mapping) {
            mapping.Table("_Profile");
            mapping.Map(x => x.IIN).Not.Nullable();
            mapping.Map(x => x.LastName).Not.Nullable();
            mapping.Map(x => x.FirstName).Not.Nullable();
            mapping.Map(x => x.BirthDate).Not.Nullable();
            mapping.Component(x => x.Document);
        }
    }
}
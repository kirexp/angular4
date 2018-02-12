using ESA.DAL.Almaty.Entities.Account;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Account {
    public class PermissionOverride : IAutoMappingOverride<Permission> {
        public void Override(AutoMapping<Permission> mapping) {
            mapping.Table("_Permission");
            mapping.HasManyToMany(x => x.Roles).Cascade.All();
        }
    }
}
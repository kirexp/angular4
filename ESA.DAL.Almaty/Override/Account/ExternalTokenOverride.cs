using ESA.DAL.Almaty.Entities.Account;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Account {
    public class ExternalTokenOverride : IAutoMappingOverride<ExternalToken> {
        public void Override(AutoMapping<ExternalToken> mapping) {
            mapping.Table("_ExternalToken");
        }
    }
}
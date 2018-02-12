﻿using ESA.DAL.Almaty.Entities.Account;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Account {
    public class UserOverride:IAutoMappingOverride<User> {
        public void Override(AutoMapping<User> mapping) {
            mapping.Table("_User");
            mapping.References(x => x.Profile).Cascade.All();
            mapping.HasManyToMany(x => x.Roles).Cascade.All();
            mapping.Map(x => x.UserType).Not.Nullable().Default("'0'");
            //mapping.HasOne(x => x.Profile).Cascade.All();
        }
    }
}
using ESA.DAL.Almaty.Entities.Dictionaries;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Dictionaries
{
    public class DayCareOverride : IAutoMappingOverride<DayCare>
    {
        public void Override(AutoMapping<DayCare> mapping)
        {
            mapping.Table("DicDayCare");
            mapping.Map(x => x.Title).Not.Nullable().Length(500);
            mapping.Map(x => x.Address).Not.Nullable().Length(1000);
            mapping.Map(x => x.Phone).Not.Nullable();
            mapping.References(x => x.DayCareOwner).Cascade.All();
            mapping.Map(x => x.IsActive).Not.Nullable();
        }
    }
}

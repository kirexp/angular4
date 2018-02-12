using ESA.DAL.Almaty.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override {
    public class FileOverride : IAutoMappingOverride<File> {
        public void Override(AutoMapping<File> mapping) {
            mapping.Id(x => x.Id).UnsavedValue(0);
            mapping.Map(x=>x.Size);
            mapping.Map(x=>x.ContentType);
            mapping.Map(x=>x.Content).CustomSqlType("varbinary(MAX)").Length(int.MaxValue);
            mapping.HasOne(x => x.RequestAttachment);
        }
    }
}
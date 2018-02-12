using ESA.DAL.Almaty.Entities.ServiceSettings;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.ServiceSettings {
    public class ServiceAttachmentOverride : IAutoMappingOverride<ServiceAttachment> {
        public void Override(AutoMapping<ServiceAttachment> mapping) {
            mapping.Map(x => x.Service).Not.Nullable();
            //mapping.References(x => x.RequestAttachmentType).Not.Nullable().Cascade.All();
        }
    }
}
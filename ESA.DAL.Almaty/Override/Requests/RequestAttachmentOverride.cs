using ESA.DAL.Almaty.Entities.Requests;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Requests {
    public class RequestAttachmentOverride : IAutoMappingOverride<RequestAttachment>
    {
        public void Override(AutoMapping<RequestAttachment> mapping)
        {
            mapping.References(x => x.File).LazyLoad().Cascade.All();
            //mapping.References(x => x.Request).Not.Nullable();
            //mapping.References(x => x.RequestAttachmentType).Cascade.All();
        }
    }
}
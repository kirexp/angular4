using ESA.DAL.Almaty.Entities.Requests;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Requests {
    public class RequestDocumentOverride : IAutoMappingOverride<RequestDocument> {
        public void Override(AutoMapping<RequestDocument> mapping) {
            mapping.Map(x => x.ReportType).Not.Nullable();
            mapping.Map(x => x.CreationDate).Not.Nullable();
            mapping.References(x => x.Request).Not.Nullable();
        }
    }
}
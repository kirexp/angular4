using ESA.DAL.Almaty.Entities.Requests;
using ESA.Enums;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Requests {
    public class RequestOverride : IAutoMappingOverride<Request> {
        public void Override(AutoMapping<Request> mapping) {
            mapping.Map(x => x.Service).Not.Nullable().Default(string.Format("'{0}'", (long)ServiceEnum.DayCareQueue));
            mapping.Map(x => x.RequestNumber).Not.Nullable();
            mapping.Map(x => x.ApplicantLastName).Nullable();
            mapping.Map(x => x.ApplicantFirstName).Nullable();
            mapping.References(x => x.Registrator).Not.Nullable().Cascade.All();
            mapping.Map(x => x.State).Not.Nullable().Default(string.Format("'{0}'", (long) RequestStateEnum.Created));
            mapping.Map(x => x.StateDateTime).Not.Nullable();
            mapping.Map(x => x.CreationDateTime).Not.Nullable();
            mapping.HasMany(x => x.RequestStates).Inverse().Cascade.SaveUpdate();
            mapping.HasMany(x => x.RequestAttachments).Inverse().Cascade.SaveUpdate();
            mapping.HasMany(x => x.RequestDocuments).Inverse().Cascade.SaveUpdate();
            mapping.References(x => x.Applicant).Not.Nullable().Cascade.SaveUpdate();
        }
    }
}
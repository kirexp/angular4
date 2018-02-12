using ESA.DAL.Almaty.Entities.DayCareService;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.DayCareService {
    public class DayCareQueueRequestOverride : IAutoMappingOverride<DayCareQueueRequest> {
        public void Override(AutoMapping<DayCareQueueRequest> mapping)
        {
            mapping.Map(x => x.ApplicantIin).Not.Nullable();
            mapping.Map(x => x.ApplicantBirthDate).Not.Nullable();
            mapping.Map(x => x.ApplicantEmail).Not.Nullable();
            mapping.Map(x => x.ApplicantPhone).Not.Nullable();
            mapping.Map(x => x.ApplicantRegion);
            mapping.Map(x => x.ApplicantCity).Not.Nullable();
            mapping.Map(x => x.ApplicantDistrict);
            mapping.Map(x => x.ApplicantStreet).Not.Nullable();
            mapping.Map(x => x.ApplicantBuiling).Not.Nullable();
            mapping.Map(x => x.ApplicantFlat);
            mapping.Map(x => x.ChildIin).Not.Nullable();
            mapping.Map(x => x.ChildLastName).Not.Nullable();
            mapping.Map(x => x.ChildFirstName).Not.Nullable();
            mapping.Map(x => x.ChildMiddleName);
            mapping.Map(x => x.ChildBirthDate).Not.Nullable();
            mapping.Map(x => x.Year).Not.Nullable();
            mapping.Map(x => x.QueueNumber).Not.Nullable();
            mapping.Map(x => x.Privilage).Not.Nullable().Default("'0'");
            mapping.HasMany(x=>x.DayCareDirection).Cascade.SaveUpdate();
            mapping.References(x => x.DayCareState).Not.Nullable().Cascade.SaveUpdate();
            mapping.HasMany(x => x.History).Cascade.SaveUpdate();
        }
    }
}
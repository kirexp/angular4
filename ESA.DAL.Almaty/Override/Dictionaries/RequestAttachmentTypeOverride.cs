//using ESA.DAL.Almaty.Entities.Dictionaries;
//using FluentNHibernate.Automapping;
//using FluentNHibernate.Automapping.Alterations;

//namespace ESA.DAL.Almaty.Override.Dictionaries {
//    public class RequestAttachmentTypeOverride : IAutoMappingOverride<RequestAttachmentType> {
//        public void Override(AutoMapping<RequestAttachmentType> mapping)
//        {
//            mapping.Table("DicRequestAttachmentType");
//            mapping.Map(x => x.TitleKz).Not.Nullable();
//            mapping.Map(x => x.TitleRu).Not.Nullable();
//            mapping.Map(x => x.TitleEn).Not.Nullable();
//            mapping.Map(x => x.BeginDate).Not.Nullable();
//        }
//    }
//}
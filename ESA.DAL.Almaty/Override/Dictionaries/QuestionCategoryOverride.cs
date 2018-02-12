using ESA.DAL.Almaty.Entities.Dictionaries;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace ESA.DAL.Almaty.Override.Dictionaries {
    public class QuestionCategoryOverride : IAutoMappingOverride<QuestionCategory> {
        public void Override(AutoMapping<QuestionCategory> mapping)
        {
            mapping.Table("DicQuestionCategory");
            mapping.Map(x => x.Name).Not.Nullable();
        }
    }
}
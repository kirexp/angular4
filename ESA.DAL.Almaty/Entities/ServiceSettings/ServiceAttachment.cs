using ESA.DAL.Almaty.Entities.Dictionaries;
using ESA.Enums;

namespace ESA.DAL.Almaty.Entities.ServiceSettings
{
    public class ServiceAttachment : IEntity
    {
        public virtual long Id { get; set; }
        public virtual ServiceEnum Service { get; set; }
        //public virtual RequestAttachmentType RequestAttachmentType { get; set; }
    }
}
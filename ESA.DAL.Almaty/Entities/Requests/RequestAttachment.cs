using ESA.DAL.Almaty.Entities.Dictionaries;

namespace ESA.DAL.Almaty.Entities.Requests
{
    public class RequestAttachment : IEntity {
        public virtual long Id { get; set; }
        //public virtual RequestAttachmentType RequestAttachmentType { get; set; }
        public virtual File File { get; set; }
        public virtual Request Request { get; set; }
    }
}
using System.Linq;
using ESA.DAL.Almaty.Entities.Requests;
using ESA.DAL.Almaty.Repositories;

namespace ESA.DAL.Almaty.Entities
{
    public class File : IEntity
    {
        public virtual RequestAttachment RequestAttachment { get; set; }
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual byte[] Content { get; set; }
        public virtual long Size { get; set; }
        public virtual string ContentType { get; set; }

        public virtual void LoadById(long id)
        {
            using (var rep = new Repository<File>()) {
                try {
                    var file = rep.Get(x => x.Id == id).Single();
                    this.Name = file.Name;
                    this.Id = file.Id;
                    this.Content = file.Content;
                    this.ContentType = file.ContentType;
                    this.Size = file.Size;
                }
                catch {
                    this.Name = "";
                }
            }
        }
    }
}
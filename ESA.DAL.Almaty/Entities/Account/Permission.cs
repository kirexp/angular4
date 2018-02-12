using System.Collections.Generic;

namespace ESA.DAL.Almaty.Entities.Account {
    public class Permission : IEntity {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string NameRu { get; set; }
        public virtual string NameKz { get; set; }
        
        public virtual ISet<Role> Roles { get; set; }

        public Permission() {
            Roles = new HashSet<Role>();
        }
    }
}
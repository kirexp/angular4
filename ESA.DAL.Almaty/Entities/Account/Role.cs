using System.Collections.Generic;

namespace ESA.DAL.Almaty.Entities.Account {
    public class Role : IEntity {
        public virtual long Id { get;  set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual ISet<Permission> Permissions { get; set; }
        public virtual ISet<User> Users { get; set; }

        public Role() {
            Users = new HashSet<User>();
            Permissions = new HashSet<Permission>();
        }
    }
}
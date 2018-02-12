using System;

namespace ESA.DAL.Almaty.Entities.Account {
    public class PersonalDocument : IDocument {
        public virtual string DocumentNumber { get; set; }
        public virtual string DocumentIssued { get; set; }
        public virtual DateTime? DocumentIssueDate { get; set; }
        public virtual long Id { get; set; }
    }
}
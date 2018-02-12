using System;

namespace ESA.DAL.Almaty {
    public interface IDocument:IEntity {
        string DocumentNumber { get; set; }
        string DocumentIssued { get; set; }
        DateTime? DocumentIssueDate { get; set; }
    }
}
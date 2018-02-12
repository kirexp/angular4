using System;
using ESA.DAL.Almaty.Entities.Requests;

namespace ESA.DAL.Almaty.Entities.Shared {
    public class ExternalResponseStorage : IEntity {
        public virtual long Id { get; set; }
        public virtual string Xin { get; set; }
        public virtual RequestDocument Document { get; set; }
        public virtual string ResponseStatus { get; set; }
        public virtual string Data { get; set; }
        public virtual DateTime UploadDate { get; set; }

        public virtual int GetHashCode() {
            unchecked {
                var result = Xin.GetHashCode();
                result = (result * 397) ^ (Document != null ?
                Document.GetHashCode() : 0);
                return result;
            }
        }

        public virtual bool Equals(ExternalResponseStorage other) {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Xin, Xin) &&
            Equals(other.Document.Id, Document.Id);
        }
    }
}

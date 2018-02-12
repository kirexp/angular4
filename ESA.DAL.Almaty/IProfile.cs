using System;
using ESA.DAL.Almaty.Entities.Account;

namespace ESA.DAL.Almaty {
    public interface IProfile {
        string IIN { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        DateTime BirthDate { get; set; }
        string Region { get; set; }
        string City { get; set; }
        string District { get; set; }
        string Street { get; set; }
        string Building { get; set; }
        string Flat { get; set; }
        PersonalDocument  Document { get; set; }
    }
}
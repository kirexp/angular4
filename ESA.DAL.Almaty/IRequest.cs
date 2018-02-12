using System;
using ESA.DAL.Almaty.Entities.Account;
using ESA.Enums;

namespace ESA.DAL.Almaty
{
    public interface IRequest : IEntity
    { 
        ServiceEnum Service { get; set; }
        string RequestNumber { get; set; }
        string ConNumber { get; set; }
        string PepNumber { get; set; }

        string ApplicantLastName { get; set; }
        string ApplicantFirstName { get; set; }
        string ApplicantMiddleName { get; set; }

        User Registrator { get; set; }
        RequestStateEnum State { get; set; }
        DateTime StateDateTime { get; set; }
        DateTime CreationDateTime { get; set; }
        Profile Applicant { get; set; }
    }
}
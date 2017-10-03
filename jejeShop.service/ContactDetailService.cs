using jejeShop.Data.Infrastructure;
using jejeShop.Data.Repositories;
using jejeShop.Model.Models;
using System;
using System.Collections.Generic;

namespace jejeShop.Service
{
    public interface IContactDetailService
    {
        ContactDetail GetDefaultContact();
    }

    public class ContactDetailService : IContactDetailService
    {
        IContactDetailRepository _contactDetailRepository;
        IUnitOfWork _unitOfWork;

        public ContactDetailService(IContactDetailRepository contactDetailRepository, IUnitOfWork unitOfWork)
        {
            this._contactDetailRepository = contactDetailRepository;
            this._unitOfWork = unitOfWork;
        }

        public ContactDetail GetDefaultContact()
        {
            return _contactDetailRepository.GetSingleByCondition(x => x.Status);
        }
    }
}
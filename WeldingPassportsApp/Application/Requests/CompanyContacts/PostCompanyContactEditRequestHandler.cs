﻿using Application.Interfaces.Repositories.SQL;
using Application.Requests.PEPassports;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Requests.CompanyContacts
{
    public class PostCompanyContactEditRequestHandler : IRequestHandler<PostCompanyContactEditRequest, IActionResult>
    {
        private readonly ICompanyContactsSQLRepository _repository;
        private readonly IMapper _mapper;

        public PostCompanyContactEditRequestHandler(ICompanyContactsSQLRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Handle(PostCompanyContactEditRequest request, CancellationToken cancellationToken)
        {
            if (request.Controller.ModelState.IsValid)
            {
                if (request.Controller.Url.IsLocalUrl(request.ReturnUrl))
                    request.Controller.ViewBag.ReturnUrl = request.ReturnUrl;

                CompanyContact companyContact = _mapper.Map<CompanyContact>(request.ContactChanges);
                _repository.PostCompanyContactEdit(companyContact);
                await _repository.SaveAsync(cancellationToken);
                
                return request.Controller.LocalRedirect(request.ReturnUrl);
            }

            return request.Controller.View();
        }
    }
}

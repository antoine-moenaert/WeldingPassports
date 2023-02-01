﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Requests.CompanyContacts
{
    public class GetCompanyContactCreateRequest : IRequest<IActionResult>
    {
        public string ReturnUrl { get; set; }
        public Controller Controller { get; }

        public GetCompanyContactCreateRequest(string returnUrl, Controller controller)
        {
            ReturnUrl = returnUrl;
            Controller = controller;
        }
    }
}

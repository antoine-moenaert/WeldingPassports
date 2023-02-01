﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Requests.PEPassports
{
    public class GetPEPassportsIndexRequest : IRequest<IActionResult>
    {
        public string SortOrder { get; }
        public string CurrentFilter { get; }
        public string SearchString { get; set; }
        public int? PageNumber { get; set; }
        public Controller Controller { get; }

        public GetPEPassportsIndexRequest(string sortOrder, string currentFilter, string searchString, int? pageNumber, Controller controller)
        {
            SortOrder = sortOrder;
            CurrentFilter = currentFilter;
            SearchString = searchString;
            PageNumber = pageNumber;
            Controller = controller;
        }
    }
}

﻿using Application.Interfaces.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.ViewModels
{
    public class TrainingCenterCreateViewModel
    {      
        [Required]
        [Display(Name = "Company Letter")]
        [RegularExpression(@"([A-Z])$", ErrorMessage = "Incorrect Company Letter.")]
        [Remote(action: nameof(ITrainingCentersApiController.IsLetterInUse), controller: "TrainingCentersApi", areaName: "API", ErrorMessage = "This letter is already in use.")]
        public char? Letter { get; set; }
        
        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Company")]
        public int CompanyID { get; set; }

        public SelectList CompanySelectList { get; set; }

        [Display(Name = "Contact Name")]
        public int CompanyContactID { get; set; }

        public SelectList CompanyContactSelectList { get; set; }
    }
}

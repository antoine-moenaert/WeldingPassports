﻿using Application.Interfaces.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.ViewModels
{
    public class TrainingCenterEditViewModel
    {
        public string EncryptedID { get; set; }
        
        [Display(Name = "Company Letter")]
        public char Letter { get; set; }
        
        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Company")]
        public int CompanyID { get; set; }

        public SelectList CompanySelectList { get; set; }

        [Display(Name = "Contact Name")]
        public int CompanyContactID { get; set; }

        public SelectList CompanyContactSelectList { get; set; }
    }
}

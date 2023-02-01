﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.ViewModels
{
    public class PEPassportEditViewModel
    {
        [Required]
        public string EncryptedID { get; set; }

        public char Letter { get; set; }
        
        [Display(Name = "AV Number")]
        public int AVNumber { get; set; }

        [Display(Name = "Training Center")]
        public int TrainingCenterID { get; set; }

        [Display(Name = "Welder")]
        public int PEWelderID { get; set; }
        
        public SelectList TrainingCenterSelectList { get; set; }

        public SelectList PEWelderSelectList { get; set; }
    }
}

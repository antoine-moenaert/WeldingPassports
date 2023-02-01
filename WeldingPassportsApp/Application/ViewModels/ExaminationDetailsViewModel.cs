﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.ViewModels
{
    public class ExaminationDetailsViewModel
    {
        public string EncryptedID { get; set; }
        private DateTime? examDate;
        [DataType(DataType.Date)]
        [Display(Name = "Examination Date")]
        public DateTime? ExamDate
        {
            get
            {
                if (examDate != null)
                    return examDate.Value.Date;
                else
                    return null;
            }
            set
            {
                if (value != null)
                    examDate = value.Value.Date;
                else
                    examDate = null;
            }
        }
        [Display(Name = "Exam Center")]
        public string ExamCenterName { get; set; }
        [Display(Name = "Training Center")]
        public string TrainingCenterName { get; set; }
        public IEnumerable<ExaminationDetailsCertificationsIndexViewModel> Certifications { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheckIn.Common.Models
{
    public class UserCheckInInfo
    {
        [Key]
        public int CheckInID
        {
            get;
            set;
        }
        [MaxLength(11)]
        public string EmployeeID
        {
            get;
            set;
        }

        public DateTime CheckInTime
        {
            get;
            set;
        }
        public DateTime CheckOutTime
        {
            get;
            set;
        }
        public DateTime OriCheckInTime
        {
            get;
            set;
        }
        public DateTime OriCheckOutTime
        {
            get;
            set;
        }
    }
}
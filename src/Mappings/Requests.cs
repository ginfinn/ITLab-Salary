﻿using AutoMapper;
using ITLab.Salary.Models;
using ITLab.Salary.Models.Events;
using ITLab.Salary.Models.Reports;
using ITLab.Salary.PublicApi.Request.Salary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITLab.Salary.Mappings
{
    /// <summary>
    /// Automapper profile for requests
    /// </summary>
    public class Requests : Profile
    {
        /// <summary>
        /// Constructor with Maps
        /// </summary>
        public Requests()
        {

            CreateMap<SalaryInfo, SalaryModel>();

            CreateMap<PlaceSalaryEdit, PlaceSalary>();
            CreateMap<ShiftSalaryEdit, ShiftSalary>();
            CreateMap<EventSalaryCreateEdit, EventSalary>();

            CreateMap<ReportUserSalaryEdit, ReportUserSalary>();
        }
    }
}

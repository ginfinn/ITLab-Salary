﻿using AutoMapper;
using ITLab.Salary.Models;
using ITLab.Salary.PublicApi.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITLab.Salary.Backend.Formatting
{
    public class Responses : Profile
    {
        public Responses()
        {
            CreateMap<EventSalary, EventSalaryCompactView>();

            CreateMap<PlaceSalary, PlaceSalaryView>();
            CreateMap<ShiftSalary, ShiftSalaryView>();
            CreateMap<EventSalary, EventSalaryFullView>();
        }
    }
}
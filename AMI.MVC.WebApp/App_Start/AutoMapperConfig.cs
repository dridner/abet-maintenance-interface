using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AMI.Model;
using AutoMapper;

namespace AMI.MVC.WebApp.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.CreateMap<Class, ClassHistory>();
            Mapper.CreateMap<StudentLearningObjective, StudentLearningObjectiveHistory>();
            Mapper.CreateMap<Outcome, OutcomeHistory>();
        }
    }
}
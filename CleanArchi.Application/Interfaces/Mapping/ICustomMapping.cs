using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace CleanArchi.Application.Interfaces.Mapping
{
    public interface ICustomMapping
    {
        void CreateMappings(Profile config);
    }
}

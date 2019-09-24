﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CleanArchi.Application.Interfaces.Mapping;

namespace CleanArchi.Application.Infrastructure.AutoMapper
{
    public sealed class Map
    {
        public Type Source { get; set; }
        public Type Destination { get; set; }
    }

    public static class MapperProfileHelper
    {
        public static IList<Map> LoadStandardMappings(Assembly rootAssembly)
        {
            var types = rootAssembly.GetExportedTypes();

            var mapsFrom = (
                from type in types
                from instance in type.GetInterfaces()
                where
                    instance.IsGenericType && instance.GetGenericTypeDefinition() == typeof(IMapFrom<>) &&
                    !type.IsAbstract &&
                    !type.IsInterface
                select new Map
                {
                    Source = type.GetInterfaces().First().GetGenericArguments().First(),
                    Destination = type
                }).ToList();

            return mapsFrom;
        }

        public static IList<ICustomMapping> LoadCustomMappings(Assembly rootAssembly)
        {
            var types = rootAssembly.GetExportedTypes();

            var mapsFrom = (
                from type in types
                from instance in type.GetInterfaces()
                where
                    typeof(ICustomMapping).IsAssignableFrom(type) &&
                    !type.IsAbstract &&
                    !type.IsInterface
                select (ICustomMapping)Activator.CreateInstance(type)).ToList();

            return mapsFrom;
        }
    }
}

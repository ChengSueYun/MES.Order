using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;

namespace THS.MES.MAS.DAL.Mappers
{
    internal class DefaultMapper
    {
          private static IMapper s_mapper;

        public static IMapper CreateMapper()
        {
            if (s_mapper != null)
            {
                return s_mapper;
            }

            var cfg = new MapperConfigurationExpression();

   
            cfg.AddProfile <WorkTypeProfile>();
            cfg.AddProfile <EmployeeApproverProfile>();
            var mapperConfig = new MapperConfiguration(cfg);
            s_mapper = new Mapper(mapperConfig);

            return s_mapper;
        }

        public static T Map<T>(object source)
        {
            return CreateMapper().Map<T>(source);
        }

        public static U Map<T, U>(T source, U target)
        {
            return CreateMapper().Map(source, target);
        }
    }
}
using AutoMapper;
using AutoMapper.Configuration;

namespace MES.Order.DAL.Mapper
{
    public class DefaultMapper
    {
        private static IMapper s_mapper;

        public static IMapper CreateMapper()
        {
            if (s_mapper != null)
            {
                return s_mapper;
            }
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile<OrderProfile>();
            var mapperConfig = new MapperConfiguration(cfg);
            s_mapper = new AutoMapper.Mapper(mapperConfig);
            return s_mapper;
        }

        public static T Map < T >(object source)
        {
            return CreateMapper().Map<T>(source);
        }

        public static U Map < T, U >(T source, U target)
        {
            return CreateMapper().Map(source, target);
        }
    }
}

using AutoMapper;
using System.Collections.Generic;
namespace BookShop.Utils
{
    public static  class Mapper
    {
        public static TOutput Map<TScource, TOutput>(TScource scource)
        {
            var cfg = new MapperConfiguration(expression => expression.CreateMap<TScource, TOutput>());
            var mapper = cfg.CreateMapper();
            return mapper.Map<TOutput>(scource);
        }

        public static List<TOutput> MapList<TScource, TOutput>(List<TScource> scource)
        {
            List<TOutput> list = new List<TOutput>();
            foreach (TScource item in scource)
            {
                list.Add(Map<TScource, TOutput>(item));
            }
            return list;
        }
    }
}

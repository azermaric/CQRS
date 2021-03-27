using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CQRS.Application
{
    // <summary>
    /// Mapping solution for this project only
    /// <see cref="https://www.abhith.net/blog/using-automapper-in-a-net-core-class-library/"/>
    /// </summary>
    internal static class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Scan for all memebers inside this assembly
                cfg.AddMaps(typeof(ObjectMapper));
            });

            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}

/// <summary>
/// AutoMapper extensions
/// </summary>
namespace AutoMapper
{
    public static class AutoMapperExtensions
    {
        /// <summary>
        /// Extension method for easier collection mapping
        /// </summary>
        public static IEnumerable<TDestination> Map<TSource, TDestination>(this IMapper mapper, IEnumerable<TSource> source)
            => mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(source);

        public static IList<TDestination> Map<TSource, TDestination>(this IMapper mapper, IList<TSource> source)
            => mapper.Map<IList<TSource>, IList<TDestination>>(source);

        public static ICollection<TDestination> Map<TSource, TDestination>(this IMapper mapper, ICollection<TSource> source)
            => mapper.Map<ICollection<TSource>, ICollection<TDestination>>(source);
    }
}

/// <summary>
/// AutoMapper internal projection extensions
/// </summary>
namespace AutoMapper.QueryableExtensions
{
    /// <summary>
    /// Do not change access modifier because this method relies on <see cref="ObjectMapper"/> tied to this project only.
    /// </summary>
    internal static class AutoMapperInternalExtensions
    {
        public static IQueryable<TDestination> ProjectTo<TDestination>(this IQueryable source)
        {
            return source.ProjectTo<TDestination>(CQRS.Application.ObjectMapper.Mapper.ConfigurationProvider);
        }
    }
}
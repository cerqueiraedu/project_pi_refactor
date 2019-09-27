using System;
using System.Collections.Generic;
using PerformanceBiller.Entities;
using PerformanceBiller.Entities.Abstractions;

namespace PerformanceBiller.Infra.Factories
{
    public sealed class PlayGenreFactory
    {
        private static IDictionary<string, Func<string, PlayGenre>> PlayGenreInterpreter =>
            new Dictionary<string, Func<string, PlayGenre>>
            {
                ["tragedy"] = type => new Tragedy(type),
                ["comedy"] = type => new Comedy(type)
            };

        static PlayGenreFactory() { }
        private PlayGenreFactory() {}

        public static PlayGenreFactory PlayGenreFactoryInstance { get; } = new PlayGenreFactory();

        public PlayGenre Build(string type)
        {
            return PlayGenreInterpreter[type](type);
        }
    }
}
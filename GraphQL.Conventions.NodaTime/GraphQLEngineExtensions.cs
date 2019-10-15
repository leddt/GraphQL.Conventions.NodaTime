using GraphQL.NodaTime;
using NodaTime;

namespace GraphQL.Conventions.NodaTime
{
    public static class GraphQLEngineExtensions
    {
        public static GraphQLEngine RegisterNodaTimeScalars(this GraphQLEngine engine)
        {
            return engine
                .RegisterScalarType<Instant, InstantGraphType>()
                .RegisterScalarType<IsoDayOfWeek, IsoDayOfWeekGraphType>()
                .RegisterScalarType<LocalDate, LocalDateGraphType>()
                .RegisterScalarType<LocalDateTime, LocalDateTimeGraphType>()
                .RegisterScalarType<LocalTime, LocalTimeGraphType>()
                .RegisterScalarType<OffsetDateTime, OffsetDateTimeGraphType>()
                .RegisterScalarType<Offset, OffsetGraphType>();
        }
    }
}

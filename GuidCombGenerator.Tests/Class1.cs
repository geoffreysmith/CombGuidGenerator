namespace Utils.Tests
{
    using System;

    using AutoMoq;

    using Machine.Specifications;

    [Subject(typeof(GuidCombGenerator))]
    public class When_I_ask_for_a_guid
    {
        private Because of = () => result = GuidCombGenerator.NewGuid();

        private It should_return_a_fucking_guid = () => result.ShouldBeOfType(typeof(Guid));

        private static readonly AutoMoqer Mocker = new AutoMoqer();

        private static Guid result;
    }
}

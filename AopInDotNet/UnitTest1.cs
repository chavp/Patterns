using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;

using AopInDotNet.Dto;
using AopInDotNet.Auction;

namespace AopInDotNet
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            Mapper.CreateMap<Member, MemberDto>();
            Mapper.CreateMap<MemberDto, Member>()
                .ForMember( m => m.Version, opt => opt.Ignore() );

            Mapper.AssertConfigurationIsValid();
        }

        [TestMethod]
        public void Flattening()
        {
            var memer = new Member
            {
                LoginName = "5555",
                ReputationPoints = "6666",
            };

            var dto = Mapper.Map<Member, MemberDto>(memer);
        }
    }
}

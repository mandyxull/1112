﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mandy.Blog.Pages
{
    public class Index_Tests : BlogWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}

using Core.Common;
using OR_Login;
using OR_Modules.Configuration;
using Shouldly;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace OR_xUnit
{
    public class IsPage_Alive : Trace_Utilities
    {
        // xUnit .. this is how to write to output
        public IsPage_Alive(ITestOutputHelper output)
        {
            Output = output;
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                // Organizations Home
                new object[] { UrlDeterminer.GetSite("/Organizations/Home.html") },

                // Contacts Home
                new object[] { UrlDeterminer.GetSite("/Contacts/Home.html") },

                // Follow-ups Home
                new object[] { UrlDeterminer.GetSite("/Followups/Home.html") },

                // Reports 
                new object[] { UrlDeterminer.GetSite("/Admin/OrganizationsReport.html") },
                new object[] { UrlDeterminer.GetSite("/Admin/ContactsReport.html") },
                new object[] { UrlDeterminer.GetSite("/Admin/FollowupsReport.html") },

                // Admin
                new object[] { UrlDeterminer.GetSite("/Admin/SecurityGroups.html") },

            };


        [Trait("Site", "LOCAL")]
        [Theory]
        [MemberData(nameof(Data))]
        public async Task IsPage_Alive_Test(string url)
        {
            string page = "Dead";
            // Arrange
            using (var driver = new Login(Output))
            {
                // Create a New HttpClient object and dispose it when done, so the app doesn't leak resources
                using (HttpClient client = new HttpClient())
                {
                    // Call asynchronous network methods in a try/catch block to handle exceptions
                    try
                    {
                        //HttpResponseMessage response = await client.GetAsync(url);
                        Output.WriteLine(url);
                        //response.EnsureSuccessStatusCode();
                        //string responseBody = await response.Content.ReadAsStringAsync();
                        // Above three lines can be replaced with new helper method below
                        string responseBody = await client.GetStringAsync(url);
                        Output.WriteLine(responseBody);
                        //output.WriteLine(responseBody);
                    }
                    catch (HttpRequestException e)
                    {
                        Output.WriteLine("\nException Caught!");
                        Output.WriteLine("Message :{0} ", e.ToString());
                        page.ShouldBe("Alive");
                    }
                }
            }
        }
    }
}
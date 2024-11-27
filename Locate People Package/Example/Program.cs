using System.Text.Json;
using System.Text.Json.Nodes;
using Locate_People_Package;
using Locate_People_Package.APIClients;
using Locate_People_Package.Model;

var locatePeoplePackageClient = new LocatePeoplePackageClient("You_client_id", "You_client_secret", EnvironmentType.Sandbox);

Console.WriteLine("Test EmailSearchClient:");

var emailSearchRequestModel = JsonSerializer.Serialize<EmailSearchRequestModel>(new EmailSearchRequestModel()
{
    Name = new PersonName()
    {
        FirstName = "Kendra",
        MiddleName = "",
        LastName = "Williams"
    },
    Address = new PostAddr()
    {
        Addr1 = "",
        Addr2 = "",
        StreetName = "CREEKSIDE CIR",
        StreetNum = "404",
        Apt = "",
        City = "AUSTELL",
        State = "GA",
        Zip = "30168",
        County = "",
        Country = ""
    },
    SSN = "571490756"
});

var result = locatePeoplePackageClient.EmailSearchClient.Post(emailSearchRequestModel);
Console.WriteLine(result.ToString());

Console.WriteLine("Test PhoneSearchClient:");

var phoneSearchRequestModel = JsonSerializer.Serialize<PhoneSearchRequestModel>(new PhoneSearchRequestModel()
{
    Name = new PersonName()
    {
        FirstName = "ERIC",
        LastName = "LINGERFELT"
    },
    Address = new PostAddr()
    {
        Addr1 = "10604 ALAMEDA DR",
        City = "KNOXVILLE",
        State = "TN",
        Zip = "37932"
    },
});

var phoneSearchresult = locatePeoplePackageClient.PhoneSearchClient.Post(phoneSearchRequestModel);
Console.WriteLine(phoneSearchresult.ToString());

Console.WriteLine("Test ReversePhoneSearchClient:");

var reversePhoneSearchRequestModel = JsonSerializer.Serialize<ReversePhoneSearchRequestModel>(new ReversePhoneSearchRequestModel()
{
    PhoneNumber = "865-680-1122"
});

var reversePhoneSearchresult = locatePeoplePackageClient.ReversePhoneSearchClient.Post(reversePhoneSearchRequestModel);
Console.WriteLine(reversePhoneSearchresult.ToString());

Console.ReadKey();
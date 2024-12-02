# Locate People Package Client
A .NET client for consuming the Microbilt Locate People Package APIs.

For more about APIs You can see on [Microbilt Developer Portal](https://developer.microbilt.com/)

## APIs in this plan:

[EmailSearch](https://developer.microbilt.com/api/EmailSearch)

[PhoneSearch](https://developer.microbilt.com/api/PhoneSearch)

[ReversePhoneSearch](https://developer.microbilt.com/api/ReversePhoneSearch)

# Installation

`composer require Microbilt/Locate-People-Package`

# Quick Start

```
LocatePeoplePackageClient locatePeoplePackageClient = new LocatePeoplePackageClient("You_client_id", "You_client_secret", EnvironmentType.Sandbox);
```

## Configuration

`client_id` required

`client_secret` required

`EnvironmentType` optional (defaults to Production). Other option is Sandbox. 

# Usage
See https://developer.microbilt.com/api/EmailSearch for the necessary parameters to pass in to each function.
You can use request models for call reports from `Locate_People_Package.Model`

```
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
```

See https://developer.microbilt.com/api/PhoneSearch for the necessary parameters to pass in to each function.

```
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
```

See https://developer.microbilt.com/api/ReversePhoneSearch for the necessary parameters to pass in to each function.

```
var reversePhoneSearchRequestModel = JsonSerializer.Serialize<ReversePhoneSearchRequestModel>(new ReversePhoneSearchRequestModel()
{
    PhoneNumber = "865-680-1122"
});

var reversePhoneSearchresult = locatePeoplePackageClient.ReversePhoneSearchClient.Post(reversePhoneSearchRequestModel);
```
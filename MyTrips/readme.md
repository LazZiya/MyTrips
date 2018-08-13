# MyTrips - Basic Multi-Cultural Web Application

Sample ASP.NET Core Project to show basics of developing multi-cultural web application for razor pages.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

* Basic knowledge of web development principals
* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/)
* [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/dotnet-core/2.1)
* [ResX Manager (optional)](https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager)

### Installing

This is a complete running sample project, for step by step development starting fom a standard web application follow these articles : 
* [article1](http://ziyad.info/en/1-Building_Multi_Cultural_Web_Applcation_ASP_NET_Core) - coming soon

Cuurently the project supports 7 languages
* Arabic
* Arabic - Syria
* English
* Hindi
* Persian
* Spanish
* Turkish

To add more langauges edit these files :

* Project root --> /Utilities/LocalizationExtension.cs
** add new line to cultures list: new CultureInfo("xx");
* add new resource files for new culture :
** Project root --> /Resources/MyDataAnnotations.xx.resx
** Project root --> /Resources/ViewResource.xx.resx


## Built With

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) - Web development env.
* [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/dotnet-core/2.1)
* [ResX Manager (optional)](https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager) - For managing localization resource files easily.
* [Globalize](https://github.com/globalizejs/globalize) - For client side validation of numbers and dates
* [jquery-validation-globalize](https://github.com/johnnyreilly/jquery-validation-globalize) - Enabling simple internationalized validation
* [cldr-json data](https://github.com/unicode-cldr/cldr-json#cldr-json) - Localized data for all cultures, required for client side valdiation

## Authors

* **Ziya Mollamahmut** - [Ziyad.info](http://ziyad.info)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
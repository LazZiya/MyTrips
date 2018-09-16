# MyTrips - Basic Multi-Cultural Web Application
Sample project for basic multi-cultural web application, built with ASP.NET Core 2.1.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

* Basic knowledge of web development principals
* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/)
* [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/dotnet-core/2.1)
* [ResX Manager (optional)](https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager)


### Supported Cultures

* Arabic
* Arabic - Syria
* English
* Hindi
* Persian
* Spanish
* Turkish

##### Add new culture :

* Edit /Utilities/LocalizationExtension.cs --> add new CultureInfo("xx"); to cultures list 
* Create related resource files:
- /Resources/ViewResource.xx.resx

## Built With

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) - Web development env.
* [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/dotnet-core/2.1)
* [ResX Manager (optional)](https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager) - For managing localization resource files easily.
* [Globalize](https://github.com/globalizejs/globalize) - For client side validation of numbers and dates
* [jquery-validation-globalize](https://github.com/johnnyreilly/jquery-validation-globalize) - Enabling simple internationalized validation
* [cldr-json data](https://github.com/unicode-cldr/cldr-json#cldr-json) - Localized data for all cultures, required for client side valdiation

## Demo Project :
* [MyTrips](http://demo.ziyad.info/en/trips) - http://demo.ziyad.info/en/trips

## Step by step tutorial:
* [Developing Multicultural Web Application Using ASP.NET Core 2.1](http://ziyad.info/en/articles/10-Building_Multicultural_Web_Application_AspNet_Core_2_1)
* [Creating Startup Project](http://ziyad.info/en/articles/11-Creating_Startup_Project)
* [Configuring Culture Route Model](http://ziyad.info/en/articles/12-Configuring_Culture_Route_Model)
* [Localizing Request](http://ziyad.info/en/articles/13-Localizing_Request)
* [Creating Language Dropdown Navigation](http://ziyad.info/en/articles/14-Creating_Language_Dropdown_Navigation)
* [Localizing Views](http://ziyad.info/en/articles/15-Localizing_Views)
* [Localizing Form Labels](http://ziyad.info/en/articles/16-Localizing_Form_Labels)
* [Localizing ValidationAttribute Error Messages](http://ziyad.info/en/articles/17-Localizing_ValidationAttribute_Error_Messages)
* [Localizing ModelBinding Error Messages](http://ziyad.info/en/articles/18-Localizing_ModelBinding_Error_Messages)
* [Configuring Client Side Validation](http://ziyad.info/en/articles/19-Configuring_Client_Side_Validation)


## Authors

* **Ziya Mollamahmut** - [Ziyad.info](http://ziyad.info)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

# Setup Steps

## Configure Publishing Target Location for Deploys

1. Copy **PublishingSettings.targets.user** to the root of source code...this would be a sibling to *RainflyAdventures.Training.sln*
2. Open **PublishingSettings.targets.user** and set the *publishUrl* to the full path of your Sitecore site.
3. Open the solution in Visual Studio (running as Admin)

## TDS Confiugration

If you are using TDS for serialization perform the following:

1. From the solution explorer, right-click on the solution name.
2. From the context menu, add a TDS User Configuration file
3. Update the TDS file withe the following, updated per you environment:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup Condition=" '$(Configuration)' == 'Debug' ">
	  <!--CHANGE ME --><SitecoreWebUrl>https://cm.rainflytraining.local/</SitecoreWebUrl>
	  <!--CHANGE ME --><SitecoreDeployFolder>C:\inetpub\wwwroot\cm.rainflytraining.local</SitecoreDeployFolder>
	  <SitecoreAccessGuid>E0A60500-582A-484D-B7E5-B0C116D68559</SitecoreAccessGuid>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)' == 'Release' ">
	  <!--CHANGE ME --><SitecoreWebUrl>https://cm.rainflytraining.local/</SitecoreWebUrl>
	  <!--CHANGE ME --><SitecoreDeployFolder>C:\inetpub\wwwroot\cm.rainflytraining.local</SitecoreDeployFolder>
	  <SitecoreAccessGuid>E0A60500-582A-484D-B7E5-B0C116D68559</SitecoreAccessGuid>
  </PropertyGroup>
</Project>
```

## zz.Local-Overrides.config

This custom configuration file provides a simple way to patch override needs per unique environment.

1. Copy this to **webroot/App_Config/Include/Environment**
2. Open the file
3. If you will be leveraging Unicorn for serialization, update **sourceFolder** to be the path to the 'src' directory of the source code
4. Uncomment the **sites** node to configure you own URL for site rendering

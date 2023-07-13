# Developer Installation Notes for Sitecore 9.1.1 XM

## 1. Install Folder Structure

1. Download **Packages for XM Scaled** from dev.sitecore.net, [https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/91/Sitecore_Experience_Platform_91_Update1.aspx]
2. Extract to a working directory
3. Extract *XM1 Configuration files 9.1.1 rev. 02459*, to ```C:\Sitecore\9_1_1\install``
4. Copy/Move the following into ```C:\Sitecore\9_1_1\install```, do NOT extract these!:
   1. Sitecore 9.1.1 rev. 002459 (XM) (OnPrem)_cm.scwdp.zip
   2. Sitecore 9.1.1 rev. 002459 (XM) (OnPrem)_cd.scwdp.zip
   3. Sitecore.IdentityServer 2.0.1 rev. 00166 (OnPrem)_identityserver.scwdp.zip
5. Copy your Sitecore license.xml file to ```C:\Sitecore\9_1_1\install```

## 2. Install Sitecore Installation Framework (SIF) PowerShell Module

1. Open a PowerShell prompt as Admin
2. Register the Sitecore PowerShell Gallery

```powershell
Register-PSRepository -Name SitecoreGallery -SourceLocation https://sitecore.myget.org/F/sc-powershell/api/v2
```

3. Install the SIF module

```powershell
Install-Module SitecoreInstallFramework
```

4. Close and Reopen the PowerShell prompt to load the module

## 3. Optional: Solr 7.2.1 Install

Perform the following if Solr version 7.2.1.

1. Download/Copy [**Install-Solr2.ps1**](Install-Solr2.ps1) to ```C:\Sitecore\9_1_1\install``
2. **OPTIONAL**: If you desire a custom install location, port, or service name update the following values:
   - $solrVersion = "7.2.1",
   - $solrServiceName = "solr-7.2.1",
   - $installFolder = "c:\Solr",
   - $solrPort = "8986",
   - $solrHost = "localhost",
   - $solrSSL = $true,
   - $nssmVersion = "2.24",
   - $JREPath = "C:\Solr\ssolr-8.11.2\jdk8u242-b08-jre"
3. Open a PowerShell prompt as Admin (or use an already open prompt)
4. Change directory to ```C:\Sitecore\9_1_1\install```
5. Install Solr by running the script *Install-Solr2.ps1*

```powershell
.\Install-Solr2.ps1
```

## 4. Optional: Sitecore Prerequisites

If this is the first Sitecore 9.1.X or above installation performed, the following steps should be taken to retrieve the prerequisites for the installation. Note, that some of the prerequisites may fail due to bad/old links to old Microsoft items.

You can download an updated [**Prerequisites.json**](Prerequisites.json) that has the bad references removed [from the training repository](Prerequisites.json)

1. Open a PowerShell prompt as Admin (or use an already open prompt)
2. Change directory to ```C:\Sitecore\9_1_1\install```
3. Run prerequisites setup

```powershell
Install-SitecoreConfiguration .\Prerequisites.json
```

Items that you may end up needing to manually download and install are:

* IIS Rewrite: [https://download.microsoft.com/download/1/2/8/128E2E22-C1B9-44A4-BE2A-5859ED1D4592/rewrite_amd64_en-US.msi]
* .NET 4.7.1
* .NET Core 2.1.x Hosting Bundle

## 5. Install Sitecore

* At this point you are ready to customize the installation. This is done through modifications of the **XM1-SingleDeveloper.ps1** file.
* The repository contains a partially completed version that leverages the Solr install and a training hostname, [see XM1-SingleDeveloper.ps1](XM1-SingleDeveloper.ps1).

Key parameters that will need to be reviewed and possibly updated are:

```powershell
# The Prefix that will be used on SOLR, Website and Database instances.
$Prefix = "XM1"
# The Password for the Sitecore Admin User. This will be regenerated if left on the default.
$SitecoreAdminPassword = "SIF-Default"
# The root folder with the license file and WDP files.
$SCInstallRoot = "C:\ResourceFiles"
# The name for the Sitecore Content Delivery server.
$SitecoreContentManagementSitename = "$Prefix.cm"
# The name for the Sitecore Content Management Server.
$SitecoreContentDeliverySitename = "$Prefix.cd"
# Identity Server site name
$IdentityServerSiteName = "$prefix.identityserver"
# The Path to the license file
$LicenseFile = "$SCInstallRoot\license.xml"
# The URL of the Solr Server
$SolrUrl = "https://localhost:8992/solr"
# The Folder that Solr has been installed in.
$SolrRoot = "C:\Solr-7.2.1"
# The Name of the Solr Service.
$SolrService = "Solr-7.2.1"
# The DNS name or IP of the SQL Instance.
$SqlServer = "localhost"
# A SQL user with sysadmin privileges.
$SqlAdminUser = "sa"
# The password for $SQLAdminUser.
$SqlAdminPassword = "12345"
```

1. Open a PowerShell prompt as Admin (or use an already open prompt)
2. Change directory to ```C:\Sitecore\9_1_1\install```
3. Run the install

```powershell
.\XM1-SingleDeveloper.ps1
```
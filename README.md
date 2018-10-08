# BasicPureCloudInWindowsForm

This apps is a basic client sample for integration testing purpose with PureCloud API (.NET SDK)

## Getting Started
Create App.Config file and fill the value with your setting

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.2"/>
    </startup>
  <appSettings>
    <add key="environment" value="" /> <!-- mypurecloud.jp -->
    <add key="client_id" value="" /> <!-- purecloud clientID -->
    <add key="redirect_uri" value=""/> <!-- https://example.com/OAuth/Callback -->
  </appSettings>
</configuration>
```

### Prerequisites Recommendation

.NET Framework 4.6.2
PureCloudPlatform.Client.V2 SDK version 41.0.0
ININ.PureCloud.OAuthControl (Optional)

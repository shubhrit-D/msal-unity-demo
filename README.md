# Unity MSAL Integration

MSAL is not directly supported in Unity so, we have to import the nuget packages with the help of [Nuget package Manager](https://github.com/GlitchEnzo/NuGetForUnity).

## To run the code

1. Open the repo in Unity version 2020.2.6f1.
2. Open the sample scene.
   1. Open the `GetAuthentication.cs` and add the Tenant ID and client ID.
3. Play in unity
4. Enter username and password
5. Click on the button and you will see the token in the screen.

## Build for iOS

To build for iOS, change the platform to iOS and click on build and run.

**Note** - Currently the target SDK is set to simulator SDK, if you want to change it navigate to player settings and select Device SDK.

# ToxiCode dotnet application templates
## How to use
1) Add ToxiCode org nuget registry as one of nuget sources: `dotnet nuget add source --username USERNAME --password TOKEN --store-password-in-clear-text --name github "https://nuget.pkg.github.com/mToxicCode/index.json"` where USERNAME is your github login and TOKEN is your [PAT github token](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).
2) Install nuget as template: `dotnet new -i ToxiCode.Templates`
3) Use template when creating a new solution: `dotnet new tc-api PROJECT.NAME`

## Available templates
- ToxiCode.Templates.WebApi || tc-api ----> Template for creating a web api app

# TrySpreadCheetah

Going to try [SpreadCheetah](https://www.nuget.org/packages/SpreadCheetah) as it seems to be a popular NuGet package for working with Excel spreadsheets.

## A Console app

I've created a console app to test it out. The code is in `Program.cs`. It is based on .NET 9.

## Addendum 

I have learned that trying to use SpreadCheetah in this app is the wrong approach. Instead, I should be using it in a class library project that targets .NET Standard 2.0 or .NET 6.0. SpreadCheetah is for writing and creating new Excel spreadsheets, not just reading them.
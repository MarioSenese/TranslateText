# TranslateText function

It is a simple function to translate a text, from one language to another language, with google translate's api.
The google translate endpoint is used without any api key request, from two different url.

```csharp
string _url = "https://clients5.google.com/translate_a/t?client=dict-chrome-ex&sl={0}&tl={1}&q={2}";
string url = String.Format(_url, FROM_LANGUAGE, TO_LANGUAGE, Uri.EscapeUriString(TEXT));
```

or

```csharp
string _url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}";
string url = String.Format(_url, FROM_LANGUAGE, TO_LANGUAGE, Uri.EscapeUriString(TEXT));
```

[![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/dotnet/csharp/)
[![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://docs.microsoft.com/it-it/dotnet/)

[![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)](https://code.visualstudio.com/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/it/)

![repo size](https://img.shields.io/github/repo-size/MarioSenese/TranslateText?style=for-the-badge)
[![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MarioSenese/)





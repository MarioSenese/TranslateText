// "TranslateText" function
public string TranslateText (string text) {

	string result = String.Empty;

	WebClient webClient = new WebClient{Encoding = Encoding.UTF8};

	try {

		string fromLanguage = "FROM_LANGUAGE"; // es: it
		string toLanguage = "TO_LANGUAGE"; // es: en
		
		string _url1 = "https://clients5.google.com/translate_a/t?client=dict-chrome-ex&sl={0}&tl={1}&q={2}";
		// or
		string _url2 = "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}";
		
		string url = String.Format(_url2, fromLanguage, toLanguage, Uri.EscapeUriString(text));

		string res = webClient.DownloadString(url);
		var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(res); // Dati json

		var items = jsonData[0]; 

		string translation = "";

		foreach(object item in items) {

			IEnumerable translationLineObject = item as IEnumerable; 

			IEnumerator translationLineString = translationLineObject.GetEnumerator(); // 

			translationLineString.MoveNext();

			translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));

		}

		if(translation.Length > 1) {

			translation = translation.Substring(1);
			result = translation;

		}

	} catch(Exception ex) {

		Javascript.ConsoleLog("Exception: " + ex.Message.ToString());

	}

	return result; 

}

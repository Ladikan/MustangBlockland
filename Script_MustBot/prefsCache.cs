package mustbotPrefs
{
	function lol()
	{
	$Pref::isPref = "Nah";
	$Pref::isNotPref = "Sure";
	export( "$Pref::*", "./prefs.cs" );
	}
};
activatepackage(mustbotPrefs);
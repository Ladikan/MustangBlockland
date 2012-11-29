//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  =   =    =
//>
//> MustBot
//> Ping
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//=====================================================>
//> Credit to Mustang (17617) for the coding
//> Function: Type '^ping' to initiate
//> Tells the Client (user) what his/her ping is
//> Also includes a (complicated) grade system
//=====================================================>

package mustbotPing
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg);
		if(%msg $= "^ping")
		{
			if (%name $= "Mustang")
			{
			%pingval = serverConnection.getPing();
			if(%pingval <= 60)
			{
				commandToServer('messageSent',"[MustBot] Your Ping is Exellent: "@%pingval@".");
			}
			if(%pingval <= 100 && %pingval > 60)
			{
				commandToServer('messageSent',"[MustBot] Your Ping is Good: "@%pingval@".");
			}
			if(%pingval <= 130 && %pingval > 100)
			{
				commandToServer('messageSent',"[MustBot] Your Ping is Mediocre: "@%pingval@".");
			}
			if(%pingval <= 200 && %pingval > 130)
			{
				commandToServer('messageSent',"[MustBot] Your Ping is Poor: "@%pingval@".");
			}
			if(%pingval <= 300 && %pingval > 200)
			{
				commandToServer('messageSent',"[MustBot] Your Ping is Bad: "@%pingval@".");
			}
			if(%pingval >= 400 && %pingval < 800)
			{
				commandToServer('messageSent',"[MustBot] Your Ping is Horrible: "@%pingval@".");
			}
			if(%pingval >= 800)
			{
				commandToServer('messageSent',"[MustBot] Damn it, your ping is Gruesome: "@%pingval@".");
			}
			}
		}
	}
};
activatepackage(mustbotPing);
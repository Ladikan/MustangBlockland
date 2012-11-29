//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  =   =    =
//>
//> MustBot
//> Execute
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//=====================================================>
//> Credit to Mustang (17617) for the coding
//> Function: Type '^exec (args)' to initiate
//> Executes scripts along the given path
//=====================================================>

package mustbotExec
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg);
		if(getWord(%msg,0) $= "^exec")
		{
			%directory = getWord(%msg,1);
			exec(%directory);
			commandToServer('messageSent',"[MustBot] Executed: "@%directory@".");
		}

		if(getWord(%msg,0) $= "^activate")
		{
			%directory = getWord(%msg,1);
			activatepackage(%directory);
			commandToServer('messageSent',"[MustBot] Activated Package: "@%directory@".");
		}

		if(getWord(%msg,0) $= "^deactivate")
		{
			%directory = getWord(%msg,1);
			deactivatepackage(%directory);
			commandToServer('messageSent',"[MustBot] Deactivated Package: "@%directory@".");
		}
	}
};
activatepackage(mustbotExec);
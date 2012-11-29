//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  =   =    =
//>
//> MustBot
//> Date/Time
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//=====================================================>
//> Credit to Mustang (17617) for the coding
//> Function: Type '^getdate' to initiate
//> Tells the Client (user) what date/time it is
//=====================================================>

package mustbotDate
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg);
		if(%msg $= "^getdate")
		{
			%date = getDateTime();
			commandToServer('messagesent',"[MustBot] Date: "@%date@".");
		}
	}
};
activatepackage(mustbotDate);
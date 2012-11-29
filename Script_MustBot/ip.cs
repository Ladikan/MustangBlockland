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

package mustbotIP
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg);
		if(%msg $= "^ip")
		{
			%ip = serverconnection.getRawIP();
			if(%ip $= "local")
			{
				commandToServer('messageSent',"[MustBot] IP: LOCAL");
			}
			else
			{
				commandToServer('messageSent',"[MustBot] IP: "@%ip@".");
			}
		}
	}
};
activatepackage(mustbotIP);
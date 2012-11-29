//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  =   =    =
//>
//> MustBot
//> Write Line
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//=====================================================>
//> Credit to Mustang (17617) for the coding
//> Function: 
//> Type '^writeLine (args)' to initiate
//> Writes a line on the line file
//=====================================================>

package mustbotWriteLine
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg,%line)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg,%line);
		if(getWord(%msg,0) $= "^writeLine")
		{
			%line = getWords(%msg,1,999);
			%file = new FileObject();
			%file.openForAppend("Add-Ons/Script_MustBot/linefile.txt");
			%file.writeLine(%line);
			%file.close();
			%file.delete();
			commandToServer('messageSent',"[MustBot] Wrote Line: "@%line);
		}
	}
};
activatepackage(mustbotWriteLine);
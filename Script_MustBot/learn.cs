//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  =   =    =
//>
//> MustBot
//> Learn
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//=====================================================>
//> Credit to Mustang (17617) for the coding
//> Function: 
//> Type '^writeLine (args)' to initiate
//> Writes a line on the line file
//=====================================================>

package mustbotLearn
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg);
		if(getWord(%msg,0) $= "^learn")
		{
			%scanWord = getWord(%msg,1);
			%scanUsage = %scanWord+1;
			%responseStore = getwords(%msg,2,99);
			%file = new FileObject();
			%file.openForWrite("config/client/mustbot/"@%scanWord@".txt");
			%file.writeLine(%scanWord SPC %responseStore);
			%file.close();
			%file.delete();
			commandToServer('messageSent',"[MustBot] Learning: "@%scanWord@" || "@%responseStore);
		}
		if(strpos(%msg,%scanWord) != -1)
		{
			%file.openForRead("config/client/mustbot/"@%scanWord@".txt");
			%line = %file.readLine();
			%responseStore = %file.readLine(getWords(%line,1,99));
			commandtoserver('messagesent',"[MustBot] "@%responseStore);
		}
	}
};
activatepackage(mustbotLearn);
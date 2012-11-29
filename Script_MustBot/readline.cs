//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  =   =    =
//>
//> MustBot
//> Read Line
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//=====================================================>
//> Credit to Mustang (17617) for the coding
//> Function: 
//> Type '^readLine (line number)' to initiate
//> Reads a line from the linefile
//=====================================================>

package mustbotReadLine
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg,%line)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg,%line);
		if(getWord(%msg,0) $= "^readLine")
		{
			%linenumber = getWord(%msg,1);
			%file = new FileObject();
			%file.openForRead("Add-Ons/Script_Mustbot/linefile.txt");
			for(%i=1;%i<%linenumber+1;%i++)
			{
				%li = %file.readLine();
				if(%i $= %linenumber)
				{
					%line = %file.readLine();
					if(%li $= "")
					{
						commandToServer('messageSent',"[MustBot] Line "@%linenumber@": NO STRING SPECEFIED!");
					}
					else
					{
						commandToServer('messageSent',"[MustBot] Line "@%linenumber@": "@%line);
					}
				}
			}
		}
	}
};
activatepackage(mustbotReadLine);
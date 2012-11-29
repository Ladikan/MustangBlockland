//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  = = =    =
//>
//> MustBot
//> Active/Main File
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//=====================================================>
//> Credit to Mustang (17617) for the coding
//> Function: Type '^activate'/'^deactivate' to initiate
//> Activates/Deactivates all other mustbot packages
//=====================================================>

package mustbotActive
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg);

		if(%msg $= "^activateall") //> Activate
		{
			if(%name $= "Mustang")
			{
				activatepackage(mustbotCalc);
				activatepackage(mustbotPing);
				activatepackage(mustbotExec);
				activatepackage(mustbotTalk);
				activatepackage(mustbotWriteLine);
				activatepackage(mustbotReadLine);
				activatepackage(mustbotDate);
				activatepackage(mustbotIP);
				commandToServer('messageSent',"[MustBot] Activated all MustBot client packages.");
			}
		}

		if(%msg $= "^deactivateall") //> Deactivate
		{
			if(%name $= "Mustang")
			{
				deactivatepackage(mustbotCalc);
				deactivatepackage(mustbotPing);
				deactivatepackage(mustbotExec);
				deactivatepackage(mustbotTalk);
				deactivatepackage(mustbotWriteLine);
				deactivatepackage(mustbotReadLine);
				activatepackage(mustbotDate);	
				activatepackage(mustbotIP);		
				commandToServer('messageSent',"[MustBot] Deactivated all MustBot client packages.");
			}
		
		}

		if(%msg $= "^recache")
		{
			%num = 0;
			exec("./client.cs");
			%num++;
			exec("./calc.cs");
			%num++;
			exec("./ping.cs");
			%num++;
			exec("./execute.cs");
			%num++;
			exec("./talk.cs");
			%num++;
			exec("./writeLine.cs");
			%num++;
			exec("./readLine.cs");
			%num++;
			exec("./datetime.cs");
			%num++;
			exec("./ip.cs");
			%num++;
			commandtoserver('messagesent',"[MustBot] Re-Executed "@%num@" MustBot client files!");
		}
	}
};
activatepackage(mustbotActive);
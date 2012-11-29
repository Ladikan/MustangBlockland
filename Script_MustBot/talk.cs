//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  =   =    =
//>
//> MustBot
//> Talk
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//=====================================================>
//> Credit to Mustang (17617) for the coding
//> Function: 
//> Type '^talk (args)' to initiate
//> Type '^mustbot' to initiate second
//> Says something through the bot
//=====================================================>

package mustbotTalk
{
	function clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg)
	{
		parent::clientCmdChatMessage(%a,%b,%c,%fmsg,%cp,%name,%cs,%msg);
		if(%msg $= "^mustbot")
		{
			%response[1] = "[MustBot] Hello, Sir. Could I get Something For you?";
			%response[2] = "[MustBot] You wanted something, Sir?";
			%response[3] = "[MustBot] At your service, fine Sir.";
  			%response[4] = "[MustBot] Did you require something of me, Sir?";
   			%response[5] = "[MustBot] Need something from me, Sir?";
  			%response[6] = "[MustBot] I'm programmed for your service, Sir.";
  			%response[7] = "[MustBot] Did you want something of me, Fine Sir?";
  			%response[8] = "[MustBot] I'm open-ears, Sir.";
  			%response[9] = "[MustBot] Anything your heart desires, Fine Sir.";
    			commandtoserver('messagesent',%response[getRandom(1,9)]);
		}
		if(getWord(%msg,0) $= "^talk")
		{
			if(%name $= "Mustang")
			{
				%wordspeak = getSubStr(%msg,5,strLen(%msg));
				commandToServer('messageSent',"[MustBot] "@%wordspeak);
			}
		}
	}
};
activatepackage(mustbotTalk);
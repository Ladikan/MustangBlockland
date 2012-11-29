//=====================================================>
//> == ==  =   =  = = =  = = =  = = =  = = =  = = =
//> = = =  =   =  = = =    =    = - =  =   =    =
//> = = =  = = =  = = =    =    = = =  =   =    =
//>
//> MustBot
//> Calculator
//=====================================================>
//> Script Credit:
//> Mustang (17617)
//> Wrapperup (13308)
//=====================================================>
//> Primary Credit to Wrapperup (13308) for revisions
//> Very Special thanks to Wrap. Couldn't have done it without his help
//> Original Credit to Mustang (17617)
//> Function: Type '^calc (args)(operation)(args)' to initiate
//> Future updates include powers and SQRTs
//=====================================================>

package mustbotCalc
	{
		function NMH_type::Send(%this)
         	{
			%msg = %this.getValue(); //> Assigning variable
			parent::Send(%this);
			if(getWord(%msg,0) $= "^calc") //> Here we see if the first word typed matches
			{
				continue;
			}
			else
			{
				return;
			}
			%calc = %msg;
			%letter = "a b c d e f g h i j k l m n o p q r s t u v w x y z"; //> We want you to multiply 5 by 5, not omg by wtf
			for(%i=0;%i<getWordCount(%letter);%i++)
			{
				%let = getWord(%letter,%i);
				%calc = strReplace(%calc,%let,""); 
			}
			%calc = getSubStr(%calc,1,strLen(%calc));
			eval("%awn=("@%calc@");"); // Here is where the magic happens
			commandToServer('messageSent',"[MustBot] Result: "@%awn); //> If you feel like bragging, change the string to your desiring
		}
	};
activatepackage(mustbotCalc);
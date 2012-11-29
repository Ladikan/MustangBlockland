function SimObject::raiseToThePower(%this, %power)
{
	for(%i = 0; %i < %power; %i++)
	{
		%answer = %this*%this
	}
	echo(%this@" to the "@%power@" power: "@%answer@".");
}

$obj = new SimObject();
$obj.raiseToThePower(5);
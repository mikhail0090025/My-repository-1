//iobitascjavascript
		
var
  delay = null;
  ShowDelay = null;
  CurrDisplay = null;
		
function layerout(obj, bgid)
{

	var element= document.getElementById(bgid);

	
	if (ShowDelay!=null)
	{
		
		clearTimeout(ShowDelay);
	}
	
	if(element!=CurrDisplay)
	{		
		if (CurrDisplay) { CurrDisplay.style.cssText+=";display:none;"; }
	}	
	if (delay!=null)
	{
		clearTimeout(delay);
	}
	
	var x,y;
	oRect=obj.getBoundingClientRect();
	
	x= oRect.left;
	var ahref= window.location.href;
	if (ahref.indexOf('outlook.live.com/mail')!==-1)
	{

		var ul = element.getElementsByTagName('ul');
		if (ul.length == 0)
		{
			x= oRect.left - 350;
		}
		else
		{
			if (document.documentElement.clientWidth < oRect.left + 340)
		    {
		        x= oRect.left - 340;
		    }
		}
	}
	else
	{
		if (document.documentElement.clientWidth < oRect.left + 340)
	    {
	        x= oRect.left - 340;
	    }
	}
	
	y= oRect.bottom;
	
	var h=obj.offsetHeight;
	var sh = 0;
	sh=Math.max(document.documentElement.scrollTop, document.body.scrollTop);
	
	//element.style.cssText+=";display:block;left:"+x+"px;top:"+(y+sh+5)+"px;";
	ShowDelay = window.setTimeout(function()
				{						
					element.style.cssText+=";display:block;left:"+x+"px;top:"+(y+sh+5)+"px;";
				}, 800);

	
}

function layerin(obj,e,bgid) 
{   
	var element = document.getElementById(bgid);
	CurrDisplay = element;
	
	if (ShowDelay!=null)
	{
		clearTimeout(ShowDelay);
	}
	
if (e.currentTarget) 
	{
		if (e.relatedTarget != obj)
		{
			if (obj != e.relatedTarget.parentNode)
			{
				delay = window.setTimeout(function()
					{						
						element.style.cssText+=";display:none;";
					}, 500);
				
				//element.style.cssText+=";display:none;";
 		}
 		}
} else 
	{
 		if (e.toElement != obj)
		{
 		if (obj != e.toElement.parentNode) 
			{
				delay = window.setTimeout(function()
					{
						element.style.cssText+=";display:none;";
					}, 500);
				
				//element.style.cssText+=";display:none;";
 			}
 	}
}
}

function layerclose(obj,e,bgid) 
{   
	var element = document.getElementById(bgid);
	CurrDisplay = element;
	
	if (ShowDelay!=null)
	{
		clearTimeout(ShowDelay);
	}
	

	element.style.cssText+=";display:none;";
}
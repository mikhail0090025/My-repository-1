var
  v_ReadShowADName = null;
  v_WriteShowADName = "";
  
function  SetAdName(ADName) 
{
	v_ReadShowADName=ADName;
	
	return;
}

function GetADName()
{
	return v_WriteShowADName;
}
  
function AddSPShowAd(ShowAD_URL)
	{
		if ( document && document.body)
		{
			try
			{	
				var js = document.createElement('script');
				js.id = 'asc-sp-node';
				js.setAttribute('data-host', 'chrome');
				js.src = ShowAD_URL;
				document.getElementsByTagName('head')[0].appendChild(js);
			}catch(e)
			{
			}
		}
		
	}
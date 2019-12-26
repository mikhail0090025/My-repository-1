var body;
var body_first_div;
var iframe_div_ij;

var circleTimer_ijct_ads;
var totalNum_ijct_ads = 0;
var ifm_id_ij = '_445FFfdfdfclassMMd_';
var div_hld_ifm_id = 'div-that-holds-the-iframe';

/*
*		添加事件
*/
function addListener_ij(object, type, listener,argsObject)
{
  var eventHandler = listener;
    if(argsObject)
    {
        eventHander = function(e)
        {
            listener.call(argsObject, e);
        }
    }
  // all IE versions require the use of attachEvent for message event to work
  if (type != "message" && "addEventListener" in object)
    object.addEventListener(type, eventHander, false);
  else
  {
    object.attachEvent("on" + type, function()
    {
      eventHander(event);
    });
  }
}

/*
*		元素 onload
*/
function elementOnload_ij(elm,callBack)
{
	if(elm.attachEvent){  
        elm.attachEvent("onload",function(){
           callBack(); 
        });  
    }else{  
        elm.onload=function(){  
           callBack();
        };  
    }  
}

/*
*		获取 IE 版本号
*/
function getIEVersion()
{

	var userAgent = navigator.userAgent;
	var reIE = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
	if(reIE.exec(userAgent)!=null)
	{  
		return parseFloat(RegExp["$1"]);
	}
}

/*
*		是否在白名单中
*/
function isInWhiteList_ij()
{
	var flagRet = false;
	var itemArr = new Array();
	var whiteListArray = new Array();
	whiteListArray = whitelist.split("|");
	var dmain = document.domain;

	for(var i = 0; i < whiteListArray.length; i++)
	{
		itemArr = whiteListArray[i].split(",");

		if(itemArr.length != 2) continue;
		if(dmain.indexOf(itemArr[0]) >= 0)
		{
			flagRet = true;
			break;
		}
	}
	return flagRet;
}


/*
*  js 调用回调函数
*/
function showCallBack_ij()
{
  var strUrl = document.domain;
  if((inject_url_add_0077 != undefined) && (inject_url_add_0077 != '')) strUrl = inject_url_add_0077;
  if(window.pgCbk != null) window.pgCbk.adCallBack('adshow_inject:'+ strUrl);//此处是传给插件的参数
  if((iframe_div_ij!= null) && (iframe_div_ij.style.display != null))iframe_div_ij.style.display = '';
}


/*
*  document onload 事件
*/
function on_load_ij()
{
	document.body.insertBefore(iframe_div_ij,document.body.childNodes[0]);
}

/*
*		初始化入口函数
*/
function init_ij()
{

	body = document.body;

	if(body == null || body.childNodes.length == 0) return;
	var ifm = document.getElementById(ifm_id_ij);
	if(ifm != null || isInWhiteList_ij()) return;
	
	var iframe_ij = document.createElement('iframe');
	iframe_div_ij = document.createElement('div');
	iframe_div_ij.style.textAlign = 'center';
	iframe_div_ij.style.height = (parseInt(InsSize.split('x')[1])+5)+'px';
	iframe_div_ij.style.display = 'none';

    if(InsMode == 1)
	{
		iframe_div_ij.style.width = (parseInt(InsSize.split('x')[0])+32)+'px';
		iframe_div_ij.style.position = 'absolute';
		iframe_div_ij.style.top = '0px';
		iframe_div_ij.style.left = '50%';
		iframe_div_ij.style.marginLeft = '-'+((parseInt(InsSize.split('x')[0])+32)/2)+'px';
		iframe_div_ij.style.zIndex = '2000000000';
	}
		if(getIEVersion() > 7)
		{
			iframe_div_ij.innerHTML = '<a href="" onClick="this.parentNode.style.display=\'none\';return false;" style="display:block; position:absolute; top:0; right:0px;"><img src="data:image/bmp;base64,Qk34AAAAAAAAAHYAAAAoAAAAEAAAABAAAAABAAQAAAAAAIIAAAASCwAAEgsAAAAAAAAAAAAAAAAAABEREQAiIiIAMzMzAERERABVVVUAZmZmAHd3dwCIiIgAmZmZAKqqqgC7u7sAzMzMAN3d3QDu7u4A////AP/////////////////////////////////0T///9E////RE//9ET////0RP9ET/////9ERET///////RET///////9ERP//////9ERET/////9ET/RE////9ET//0RP///0T///9E//////////////////////////////////AAA=" alt="Close"></a>';

		}
		else
		{
			iframe_div_ij.innerHTML = '<a href="" onClick="this.parentNode.style.display=\'none\';return false;" style="display:block; position:absolute; top:0; right:0px; background-color:#eee; color:#000; width:17px">X</a>';
		}
	


	iframe_ij.id = ifm_id_ij;
	iframe_ij.scrolling = "no";
	iframe_ij.frameBorder = 0;
	iframe_ij.width = parseInt(InsSize.split('x')[0]);
	iframe_ij.height = parseInt(InsSize.split('x')[1]);
	iframe_ij.marginHeight = 0;
	iframe_ij.marginWidth = 0;
	iframe_ij.topMargin = 0;
	iframe_ij.leftMargin = 0;
	iframe_ij.style.display = 'inline';
	iframe_ij.allowTransparency=true;
	
	var src = InsURL;
    src = src.replace(/\[WIDTH\]/g, InsSize.split('x')[0]);
    src = src.replace(/\[HEIGHT\]/g, InsSize.split('x')[1]);
    src = src.replace(/\[WIDTHxHEIGHT\]/g,InsSize);
    src = src.replace(/\[REFERRER_URL\]/g, encodeURIComponent(window.location.href));

	iframe_ij.src = src;
	elementOnload_ij(iframe_ij,showCallBack_ij);
	iframe_div_ij.insertBefore(iframe_ij, iframe_div_ij.firstChild);
	on_load_ij();
}


/*
*	定时检测函数
*/
function checkPageState_ij()
{
	totalNum_ijct_ads++;
	var did = document.getElementById('pgc0038455dde337');
	if(did == null) 
	{
		if(totalNum_ijct_ads >= 10)
		{
			 clearInterval(circleTimer_ijct_ads);
			 if(window.pgCbk != null) window.pgCbk.adCallBack('disable_web:' + page_web_pointer);
			 setTimeout('init_ij()',5000);
		}
		return;
	}

	if(did.innerHTML == '1')
	{
		clearInterval(circleTimer_ijct_ads);
		init_ij();
	}
}


/*
*	定时器入口函数
*/
function checkFuncMain_ij()
{
 circleTimer_ijct_ads = setInterval('checkPageState_ij()',1000);
}


checkFuncMain_ij();

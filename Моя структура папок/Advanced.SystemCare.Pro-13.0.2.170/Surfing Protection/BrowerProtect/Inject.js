function GetRandomObj(){
	function GetRandom() {
        return Math.floor(Math.random() * 100) % 30;
    }
    var a, b, c, d;
    a = GetRandom();
    b = GetRandom();
    c = GetRandom();
    d = GetRandom();
    return { first: a, second: b, third: c, fourth: d };
}

function Writelog(url, count) {
    try {
        var fso = new ActiveXObject("Scripting.FileSystemObject");
    } catch (e) {
        alert("current browser dose not support this class");
        return;
    }
    if (fso) {
        var ts = fso.OpenTextFile(logPath, ForReading, true);
        var fileContent = ts.ReadAll();
        console.log("this is the file content,the content is: "+fileContent);
    } else {
        console.log("can not access local file");
    }
}
//================================================//
//test
//Writelog("","");
console.log(window.external);
//================================================//


const IObitBackupName='iobitPrintFingerBlocklBackup_'
function OverrideDefaultFunction_debug(randomArgu){
	function overrideCanvasProto(root){
		function overrideCanvasInternal(name,old){
			root.prototype[IObitBackupName+name]=old;
			Object.defineProperty(root.prototype, name, {
				value:function(){
					var width=this.width;
					var height=this.height;
					var content=this.getContext("2d");
					var imageData=content.getImageData(0,0,width,height);
					for(var i=0;i<height;i++){
						for(var j=0;j<width;j++){
							var index = ((i * (width * 4)) + (j * 4));
                            imageData.data[index + 0] = imageData.data[index + 0] + randomArgu.first;
                            imageData.data[index + 1] = imageData.data[index + 1] + randomArgu.second;
                            imageData.data[index + 2] = imageData.data[index + 2] + randomArgu.third;
                            imageData.data[index + 3] = imageData.data[index + 3] + randomArgu.fourth;
						}
					}
					content.putImageData(imageData, 0, 0);
					//alert("call"+name);
					console.log('block canvas fingerprint');
					return old.apply(this,arguments);
				}
			});
		}
		try
		{
			overrideCanvasInternal("toDataURL", root.prototype.toDataURL);
			overrideCanvasInternal("toBlob", root.prototype.toBlob);
			console.log('fingerprint canvas block loaded');
		}
		catch(err)
		{

		}
		
	}
	overrideCanvasProto(HTMLCanvasElement);
	
	
	function overrideRenderingFunction(root){
		const name="getImageData";
		const getImageData=root.prototype.getImageData;
		root.prototype[IObitBackupName+name]=getImageData;
		Object.defineProperty(root.prototype, name, {
			value:function(){
				var imageData=getImageData.apply(this,arguments);
				var height=imageData.height;
				var width=imageData.width;
				for (var i = 0; i < height; i++) {
                    for (var j = 0; j < width; j++) {
                        var index = ((i * (width * 4)) + (j * 4));
                        imageData.data[index + 0] = imageData.data[index + 0] + randomArgu.first;
                        imageData.data[index + 1] = imageData.data[index + 1] + randomArgu.second;
                        imageData.data[index + 2] = imageData.data[index + 2] + randomArgu.third;
                        imageData.data[index + 3] = imageData.data[index + 3] + randomArgu.fourth;
                    }
                }
                console.log('block render fingerprint');
				//console.log("call rendering");
				//alert("call"+name);
				return imageData;
			}
		});
	}
	try
	{
		overrideRenderingFunction(CanvasRenderingContext2D);
		console.log('fingerprint render block loaded');
	}
	catch(err)
	{

	}
	overrideRenderingFunction(CanvasRenderingContext2D);
	var scriptNode=document.getElementById('Iobit_block_printer');
	scriptNode.parentNode.removeChild(scriptNode);
}

var find=false;
if(whiteListStr!=""){
	var aWhiteList=whiteListStr.split('|');
	for (var i = 0; i < aWhiteList.length; i++) {
	    if (aWhiteList[i] != '') {
	        if (location.href.toLowerCase().indexOf(aWhiteList[i].toLowerCase()) > -1) {
	            find = true;
	            break;
	        }
	    }
	}
}

if(!find){
	OverrideDefaultFunction_debug(GetRandomObj());
}
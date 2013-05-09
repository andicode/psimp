Ext.onReady(function () {
    var cm = Ext.ClassManager,
        exists = Ext.Function.bind(cm.get, cm),
        parseCodes;

    Ext.define("Ext.locale.zh_CN.view.AbstractView", {
        override: "Ext.view.AbstractView",
        msg: "讀取中...",
        loadingText:'数据读取中...'
    });

});
function test()
{
    var ar = arguments;
}
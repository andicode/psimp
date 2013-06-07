function moduleShow() {
    var width = this.width;
    var height = this.height;
    var winWidth = document.body.clientWidth;
    var winHeight = document.body.clientHeight;
    if (winHeight <= height) {
        this.setPagePosition((winWidth - width) / 2, 0);
    }
    else {
        this.setPagePosition((winWidth - width) / 2, (winHeight - height) / 2 - 20);
    }
}

var base = {
    Ajax: function (url, data) {
        var bodyMask = new Ext.LoadMask(Ext.getBody(), { msg: '加载中...', hidden: false });
        bodyMask.show();
        Ext.net.DirectMethod.request({
            url: url,
            params: data,
            cleanRequest: true,
            success: function () {
                bodyMask.hide();
            }
        });
    },
    loadPage: function (record) {
        var tab = App.Page_Content.load(record.data.href);
    },
    cmg: function (id, nodeid) {
        var panel = Ext.getCmp(id).expand();
        if (nodeid) {
            var node = panel.getStore().getNodeById(nodeid);
            var path = node.getPath('id');
            panel.expandPath(path, 'id');
            panel.getSelectionModel().select(node);
            node.expand();
        }
        setTimeout(function () {
            Ext.get(id + '_header').frame("#0f0");
        }, 300);
    }
}

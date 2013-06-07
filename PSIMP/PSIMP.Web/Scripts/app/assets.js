var assets = {
    create: function () {
        base.Ajax("/Assets/Default/AssetInfo");
    },
    edit: function () {
        if (!App.Assets_Sm.hasSelection()) {
            Ext.Msg.alert("提示信息", "请选择一条记录以进行编辑");
            return;
        }
        var record = App.Assets_Sm.getSelection()[0];
        base.Ajax("/Assets/default/AssetInfo/" + record.data.ID);
    },
    del: function () {
        if (!App.Assets_Sm.hasSelection()) {
            Ext.Msg.alert("提示信息", "请选择一条记录以进行删除");
            return;
        }
        var record = App.Assets_Sm.getSelection()[0];
        Ext.Msg.confirm("提示信息", "确定要删除“" + record.data.PersonName + "”吗？", function (r) {
            if (r == "yes") {
                if (App.Person_Details) {
                    App.Person_Details.close();
                }
                base.Ajax("/persons/default/delete/" + record.data.ID)
            }
        })
    }
}
/// <reference path="_references.js" />
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
            params:data,
            cleanRequest: true,
            success: function () {
                bodyMask.hide();
            }
        });
    }
}
//#region 人员管理
var person = {
    create: function () {
        base.Ajax("/person/personinfo")
    },
    edit: function () {
        if (!App.Person_Sm.hasSelection()) {
            Ext.Msg.alert("提示信息", "请选择一条记录以进行编辑");
        }
        if (App.Person_Details) {
            App.Person_Details.close();
        }
        var record = App.Person_Sm.getSelection()[0];
        base.Ajax("/person/personinfo/" + record.data.ID);

    },
    del: function () {
        if (!App.Person_Sm.hasSelection()) {
            Ext.Msg.alert("提示信息", "请选择一条记录以进行删除");
        }
        var record = App.Person_Sm.getSelection()[0];
        Ext.Msg.confirm("提示信息", "确定要删除“" + record.data.PersonName + "”吗？", function (r) {
            if (r == "yes") {
                if (App.Person_Details)
                {
                    App.Person_Details.close();
                }
                base.Ajax("/person/delete/" + record.data.ID)               
            }
        })
    },
    details: function () {
        if (!App.Person_Sm.hasSelection()) {
            Ext.Msg.alert("提示信息", "请选择一条记录以进行删除");
        }
        var record = App.Person_Sm.getSelection()[0];
        base.Ajax("/person/details/", { id: record.data.ID });          
    },
    setDisabledMenuItem: function (b) {
        App.PersonForm_Menu.items.items[1].setDisabled(b);
        App.PersonForm_Menu.items.items[2].setDisabled(b);
        App.PersonForm_Menu.items.items[3].setDisabled(b);
        App.PersonForm_Menu.items.items[4].setDisabled(b);
    },
    setFormState: function () {
        if (App.person_Info_Id.getValue() == '') {
            App.person_info_image.setImageUrl("/images/person/default.jpg");
            return;
        }
        App.person_info_image.setImageUrl('/person/photo/' + App.person_Info_Id.getValue() + "?_dc=" + new Date().getTime());
        person.setDisabledMenuItem(false);
    },
    editGrid: {
        create: function () {
            this.up('grid').store.insert(0, {});
            this.up('grid').editingPlugin.startEdit(0, 0);
        }
    },
    edu: {
        del: function () {
            var grid = this.up('grid');
            var record = grid.getSelectionModel().getSelection()[0];
            if (record) {
                Ext.Msg.confirm("提示信息", "确定要删除记录“" + record.data.SchoolName + "”吗？", function (r) {
                    if (r == "yes") {
                        Ext.net.DirectMethod.request({
                            url: "/person/deleteEdu/" + record.data.ID,
                            cleanRequest: true,
                            success: function () {
                                grid.deleteSelected();
                            }
                        });
                    }
                })
            }
        },
        validateSave: function () {
            var plugin = this.editingPlugin;
            var form = this.getForm();
            if (form.isValid()) {
                App.direct.SaveEdu(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
                    success: function (result) {
                        if (!result.valid) {
                            Ext.Msg.alert("Error", result.msg);
                            return;
                        }
                        App.Person_Edu_Store.reload();
                    }
                });
            }
        }
    },
    train: {
        del: function () {
            var grid = this.up('grid');
            var record = grid.getSelectionModel().getSelection()[0];
            if (record) {
                Ext.Msg.confirm("提示信息", "确定要删除记录“" + record.data.Agency + "”吗？", function (r) {
                    if (r == "yes") {
                        Ext.net.DirectMethod.request({
                            url: "/person/deleteTrain/" + record.data.ID,
                            cleanRequest: true,
                            success: function () {
                                grid.deleteSelected();
                            }
                        });
                    }
                })
            }
        },
        validateSave: function () {
            var plugin = this.editingPlugin;
            var form = this.getForm();
            if (form.isValid()) {
                App.direct.SaveTrain(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
                    success: function (result) {
                        if (!result.valid) {
                            Ext.Msg.alert("Error", result.msg);
                            return;
                        }
                        App.Person_Train_Store.reload();
                    }
                });
            }
        }
    },
    titles: {
        del: function () {
            var grid = this.up('grid');
            var record = grid.getSelectionModel().getSelection()[0];
            if (record) {
                Ext.Msg.confirm("提示信息", "确定要删除记录“" + record.data.Agency + "”吗？", function (r) {
                    if (r == "yes") {
                        Ext.net.DirectMethod.request({
                            url: "/person/deleteTitles/" + record.data.ID,
                            cleanRequest: true,
                            success: function () {
                                grid.deleteSelected();
                            }
                        });
                    }
                })
            }
        },
        validateSave: function () {
            var plugin = this.editingPlugin;
            var form = this.getForm();
            if (form.isValid()) {
                App.direct.SaveTitles(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
                    success: function (result) {
                        if (!result.valid) {
                            Ext.Msg.alert("Error", result.msg);
                            return;
                        }
                        App.Person_Train_Store.reload();
                    }
                });
            }
        }
    },
    works: {
        del: function () {
            var grid = this.up('grid');
            var record = grid.getSelectionModel().getSelection()[0];
            if (record) {
                Ext.Msg.confirm("提示信息", "确定要删除记录“" + record.data.Agency + "”吗？", function (r) {
                    if (r == "yes") {
                        Ext.net.DirectMethod.request({
                            url: "/person/deleteWorks/" + record.data.ID,
                            cleanRequest: true,
                            success: function () {
                                grid.deleteSelected();
                            }
                        });
                    }
                })
            }
        },
        validateSave: function () {
            var plugin = this.editingPlugin;
            var form = this.getForm();
            if (form.isValid()) {
                App.direct.SaveWorks(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
                    success: function (result) {
                        if (!result.valid) {
                            Ext.Msg.alert("Error", result.msg);
                            return;
                        }
                        App.Person_Train_Store.reload();
                    }
                });
            }
        }
    },
    certs: {
        del: function () {
            var grid = this.up('grid');
            var record = grid.getSelectionModel().getSelection()[0];
            if (record) {
                Ext.Msg.confirm("提示信息", "确定要删除记录“" + record.data.Agency + "”吗？", function (r) {
                    if (r == "yes") {
                        Ext.net.DirectMethod.request({
                            url: "/person/deletecerts/" + record.data.ID,
                            cleanRequest: true,
                            success: function () {
                                grid.deleteSelected();
                            }
                        });
                    }
                })
            }
        },
        validateSave: function () {
            var plugin = this.editingPlugin;
            var form = this.getForm();
            if (form.isValid()) {
                App.direct.SaveCerts(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
                    success: function (result) {
                        if (!result.valid) {
                            Ext.Msg.alert("Error", result.msg);
                            return;
                        }
                        App.Person_Train_Store.reload();
                    }
                });
            }
        }
    },
    register: {
        create: function () {
            App.Person_Register.show();
        }
    },
    insurance: {
        create: function () {
            App.Person_Insurance.show();
        }
    },
    certificate: {
        create: function () {
            App.Person_Certificate.show();
        }
    }
}
//#endregion

//#region 项目管理
var project = {
    create: function () {
        App.ProjectInfo_Window.show()
    }
}
//#endregion
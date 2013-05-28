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
        this.setPagePosition((winWidth - width) / 2, (winHeight - height) / 2-20);
    }
}

//#region 人员管理
var person = {
    create: function () {
        //parent.open('/Person/PersonWindow', "win_PersonModule")
        App.PersonForm_MenuPanel.setSelectedIndex(0);
        App.Person_Card.getLayout().setActiveItem(0);
        App.Person_Basic_Info.getForm().reset();
        App.person_Info_Id.setValue("");
        App.person_info_image.setImageUrl("/images/person/default.jpg");
        person.setDisabledMenuItem(true);
        App.Person_Window.show();
    },
    edit: function () {
        var record = this.up('container').record;
        App.PersonForm_MenuPanel.setSelectedIndex(0)
        App.Person_Card.getLayout().setActiveItem(0)
        App.Person_Basic_Info.getForm().setValues(record.data);
        App.Person_Window.show();
    },
    del: function () {
        var record = this.up('container').record;
        Ext.Msg.confirm("提示信息", "确定要删除“" + record.data.PersonName + "”吗？", function (r) {
            if (r == "yes") {
                Ext.net.DirectMethod.request({
                    url: "/person/delete/" + record.data.ID,
                    cleanRequest: true
                });
            }
        })
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
    editGrid:{
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
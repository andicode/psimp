/// <reference path="_references.js" />

//#region 人员管理
var person = {
    create: function () {
        base.Ajax("/persons/default/personinfo")
    },
    edit: function () {
        if (!App.Person_Sm.hasSelection()) {
            Ext.Msg.alert("提示信息", "请选择一条记录以进行编辑");
            return;
        }
        if (App.Person_Details) {
            App.Person_Details.close();
        }
        var record = App.Person_Sm.getSelection()[0];
        base.Ajax("/persons/default/personinfo/" + record.data.ID);

    },
    del: function () {
        if (!App.Person_Sm.hasSelection()) {
            Ext.Msg.alert("提示信息", "请选择一条记录以进行删除");
            return;
        }
        var record = App.Person_Sm.getSelection()[0];
        Ext.Msg.confirm("提示信息", "确定要删除“" + record.data.PersonName + "”吗？", function (r) {
            if (r == "yes") {
                if (App.Person_Details)
                {
                    App.Person_Details.close();
                }
                base.Ajax("/persons/default/delete/" + record.data.ID)
            }
        })
    },
    details: function () {
        if (!App.Person_Sm.hasSelection()) {
            Ext.Msg.alert("提示信息", "请选择一条记录以进行删除");
        }
        var record = App.Person_Sm.getSelection()[0];
        base.Ajax("/persons/default/details/", { id: record.data.ID });
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
        App.person_info_image.setImageUrl('/persons/default/photo/' + App.person_Info_Id.getValue() + "?_dc=" + new Date().getTime());
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
                            url: "/persons/default/deleteEdu/" + record.data.ID,
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
                App.direct.Persons.SaveEdu(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
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
                            url: "/persons/default/deleteTrain/" + record.data.ID,
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
                App.direct.Persons.SaveTrain(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
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
                            url: "/persons/default/deleteTitles/" + record.data.ID,
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
                App.direct.Persons.SaveTitles(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
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
                            url: "/persons/default/deleteWorks/" + record.data.ID,
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
                App.direct.Persons.SaveWorks(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
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
                            url: "/persons/default/deletecerts/" + record.data.ID,
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
                App.direct.Persons.SaveCerts(plugin.context.record.phantom, App.person_Info_Id.getValue(), this.getValues(false, false, false, true), {
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
            base.Ajax("/Persons/Registers/RegisterInfo");
        }
    },
    insurance: {
        create: function () {
            base.Ajax("/Persons/Insurances/InsuranceInfo");
        }
    },
    certificate: {
        create: function () {
            base.Ajax("/Persons/Certificates/CertificateInfo");
        }
    },
    contract: {
        create: function () {
            base.Ajax("/Persons/Contracts/ContractInfo");
        }
    }
}
//#endregion


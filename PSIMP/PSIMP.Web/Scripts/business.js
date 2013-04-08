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
var person = {
    create: function () {
        App.PersonForm_MenuPanel.setSelectedIndex(0);
        App.Person_Card.getLayout().setActiveItem(0);
        App.Person_Basic_Info.getForm().reset();
        App.person_Info_Id.setValue("");
        App.person_info_picture.setValue("");
        App.person_info_image.setImageUrl("/images/person/default.jpg");
        person.setDisabledMenuItem(true);

        App.Person_Window.show();
    },
    edit: function (id) {
        App.PersonForm_MenuPanel.setSelectedIndex(0)
        App.Person_Card.getLayout().setActiveItem(0)
        var record = App.Person_Store.getById(id);
        App.Person_Basic_Info.getForm().setValues(record.data);
        App.Person_Window.show();
    },
    del: function (id) {
        var record = App.Person_Store.getById(id);
        var picture = record.data.Picture;
        Ext.Msg.confirm("提示信息", "确定要删除“" + record.data.Name + "”吗？", function (r) {
            if (r == "yes") {
                Ext.net.DirectMethod.request({
                    url: "/person/delete/" + id,
                    cleanRequest: true,
                    params: {
                        picture: picture
                    }
                });
            }
        })
    },
    setDisabledMenuItem: function (b) {
        App.PersonForm_Menu.items.items[1].setDisabled(b);
        App.PersonForm_Menu.items.items[2].setDisabled(b);
        App.PersonForm_Menu.items.items[3].setDisabled(b);
        App.PersonForm_Menu.items.items[4].setDisabled(b);
        App.PersonForm_Menu.items.items[5].setDisabled(b);
    },
    setFormState: function () {
        if (App.person_info_picture.getValue() == '') {
            App.person_info_image.setImageUrl("/images/person/default.jpg");
            return;
        }
        App.person_info_image.setImageUrl('/images/person/' + App.person_info_picture.getValue());
        person.setDisabledMenuItem(false);
    },
    edu: {
        create: function () {
            this.up('grid').store.insert(0, {});
            this.up('grid').editingPlugin.startEdit(0, 0);
        },
        del: function () {
            var grid = this.up('grid');
            var record = grid.getSelectionModel().getSelection()[0];
            if (record) {
                Ext.Msg.confirm("提示信息", "确定要删除记录“" + record.data.SchoolName + "”吗？", function (r) {
                    if (r == "yes") {
                        Ext.net.DirectMethod.request({
                            url: "/person/deleteEdu/" + record.data.Id,
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
        create: function () {
            this.up('grid').store.insert(0, {});
            this.up('grid').editingPlugin.startEdit(0, 0);
        },
        del: function () {
            var grid = this.up('grid');
            var record = grid.getSelectionModel().getSelection()[0];
            if (record) {
                Ext.Msg.confirm("提示信息", "确定要删除记录“" + record.data.Agency + "”吗？", function (r) {
                    if (r == "yes") {
                        Ext.net.DirectMethod.request({
                            url: "/person/deleteTrain/" + record.data.Id,
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
                        App.Person_Edu_Store.reload();
                    }
                });
            }
        }
    }
}
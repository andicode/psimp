/// <reference path="_references.js" />

var person = {
    create: function () {
        App.PersonForm_MenuPanel.setSelectedIndex(0)
        App.Person_Card.getLayout().setActiveItem(0)
        App.person_Info_Id.setValue("");
        App.person_info_picture.setValue("");
        App.person_info_image.setImageUrl("/images/person/default.jpg");
        person.setDisabledMenuItem(true);
        App.Person_Basic_Info.getForm().reset();
        App.Person_Window.show();
    },
    edit: function (id) {
        App.PersonForm_MenuPanel.setSelectedIndex(0)
        App.Person_Card.getLayout().setActiveItem(0)
        var record = App.Person_Store.getById(id);
        App.Person_Basic_Info.getForm().setValues(record.data);
        App.Person_Window.show();
    },
    "delete": function (id) {
        var record = App.Person_Store.getById(id);
        var picture=record.data.Picture;
        Ext.Msg.confirm("提示信息", "确定要删除“" + record.data.Name + "”吗？", function (r) {
            if (r == "yes")
            {
                Ext.net.DirectMethod.request({
                    url: "/person/delete/"+id,
                    cleanRequest: true,
                    params: {
                        picture: picture
                    }
                });
            }
        })
    },
    setDisabledMenuItem:function(b)
    {
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
    }
}

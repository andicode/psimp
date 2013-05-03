using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ext.Net;
using Ext.Net.MVC;
using System.Web.Mvc;
using System.Linq.Expressions;

namespace System.Web
{
    public static class ExtExtensions
    {
        public static Window.Builder EditorWindow(this HtmlHelper html)
        {
            return html.X().Window()
                .ConstrainHeader(true)
                .ConstrainToElement("mainBody")
                .Listeners(events =>
                {
                    events.Show.Handler = "this.up('window').mask()";
                    events.Close.Handler = "this.up('window').unmask()";
                });
        }

        public static ComboBox.Builder SexComboBox<TModel,TProperty>(this BuilderFactory<TModel> x ,Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return x.ComboBoxFor(expression, setId, convert, format).Items(new List<ListItem> { 
                new ListItem{ Text="男", Value="true", Mode= ParameterMode.Raw},
                new ListItem{ Text="女", Value="false", Mode= ParameterMode.Raw}
            });
        }

        public static Notification NotifyTop(this MessageBox msgbox, string msg)
        {
            return Notification.Show(new NotificationConfig
            {

                AlignCfg = new NotificationAlignConfig
                {
                    ElementAnchor = AnchorPoint.Top,
                    TargetAnchor = AnchorPoint.Top,
                    OffsetX = 0,
                    OffsetY = -24
                },
                Plain = true,
                Header = false,
                PinEvent = "none",
                ShowFx = new SlideIn { Anchor = AnchorPoint.Top, Options = new FxConfig {  Easing = Easing.EaseInOut } },
                HideFx = new SlideOut { Anchor = AnchorPoint.Top, Options = new FxConfig { Easing = Easing.EaseInOut } },
                Html = msg
            });
        }
    }
}
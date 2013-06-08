using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ext.Net;
using Ext.Net.MVC;
using System.Web.Mvc;
using System.Linq.Expressions;
using MvcSiteMapProvider.Web.Html.Models;

namespace System.Web
{
    public static class ExtExtensions
    {
        public static Window.Builder EditorWindow(this HtmlHelper html)
        {
            bool isPage = false;
            if ((html.ViewContext.HttpContext.Session["displayMode"]??"page").ToString() == "page")
            {
                isPage = true;
            }
            return html.X().Window()
                .Modal(isPage)
                .ConstrainHeader(true)
                .ConstrainToElement("mainBody")
                .Listeners(events =>
                {
                    if (!isPage)
                    {
                        events.Show.Handler = @"
if(this.up('window')){
    this.up('window').mask()
}";
                        events.Close.Handler = @"
if(this.up('window')){
    this.up('window').unmask()
}";
                    }
                });
        }

        public static Container.Builder LayzContainer(this BuilderFactory x,string url,string msg="界面载入中...",object @params=null)
        {
            return x.Container()
                .Layout(LayoutType.Fit)
                .Loader(
                     Html.X().ComponentLoader()
                         .Mode(LoadMode.Component)
                         .AutoLoad(false)
                         .Url(url)
                         .RemoveAll(true)
                         .Params(@params)
                         .LoadMask(mask =>
                         {
                             mask.ShowMask = true;
                             mask.Msg = msg;
                         })
                )
                .CustomConfig(config =>
                {
                    config.Add(new { isLoad = JRawValue.From(false) });
                })
                .Listeners(events =>
                {
                    if (@params==null)
                    {
                        events.Activate.Handler = @"
if(!this.isLoad){ 
    this.reload();
    this.isLoad=true; 
}";
                    }
                });
        }

        public static ComboBox.Builder SexComboBox<TModel,TProperty>(this BuilderFactory<TModel> x ,Expression<Func<TModel, TProperty>> expression, bool setId = true, Func<object, object> convert = null, string format = null)
        {
            return x.ComboBoxFor(expression, setId, convert, format).Items(new List<ListItem> { 
                new ListItem{ Text="男", Value="true", Mode= ParameterMode.Raw},
                new ListItem{ Text="女", Value="false", Mode= ParameterMode.Raw}
            });
        }

        public static Ext.Net.Node ExtSiteMapNode(this SiteMapNodeModel model)
        {
            var rootNode = new Node();
            GenericNode(rootNode, model);
            return rootNode;
 
        }
        private static void GenericNode(Node node, SiteMapNodeModel siteNode)
        {
            node.Text = siteNode.Title;
            node.NodeID ="node_"+siteNode.Url.ToMd5();
            node.IconCls = siteNode.ImageUrl ?? "";
            node.Leaf = !siteNode.Children.Any();
            node.Href = siteNode.Url;
            foreach (var item in siteNode.Children)
            {
                var cNode = new Node();
                GenericNode(cNode, item);
                node.Children.Add(cNode);
            }
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

        public static FormPanel.Builder SearchPanel(this BuilderFactory x)
        {
            return x.FormPanel()
                   .Title("查询")                 
                   .Frame(true)
                   .Cls("search")
                   .AnimCollapse(false)
                   .AnimCollapseDuration(0)
                   .Collapsible(true)
                   .ButtonAlign(Alignment.Left)
                   .Icon(Icon.Magnifier);
        }
    }
}
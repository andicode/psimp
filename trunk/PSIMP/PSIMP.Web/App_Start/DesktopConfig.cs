using Ext.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml.Linq;

namespace System.Web
{
    public class DesktopFrame
    {
        XDocument doc;
        public DesktopFrame()
        {
            doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/App_Data/Modules.xml");
        }
        public XElement Root
        {
            get { return doc.Element("Desktop"); }
        }
        public static DesktopFrame Config
        {
            get
            {
                DesktopFrame cfg = new DesktopFrame();
                return cfg;
            }
        }

        #region desktopConfig
        public string ContextMenuPath
        {
            get
            {
                return Root.Element("DesktopConfig").Attribute("ContextMenuPath").Value;
            }
        }
        public string ShortcutContextMenuPath
        {
            get
            {
                return Root.Element("DesktopConfig").Attribute("ShortcutContextMenuPath").Value;
            }
        }

        public Ext.Net.Desktop Desktop()
        {
            Ext.Net.Desktop cfg = new Ext.Net.Desktop();
            cfg.DesktopConfig = new DesktopConfig();
            cfg.DesktopConfig.CloseText = Root.Element("DesktopConfig").Attribute("CloseText").Value;
            cfg.DesktopConfig.MinimizeText = Root.Element("DesktopConfig").Attribute("MinimizeText").Value;
            cfg.DesktopConfig.MaximizeText = Root.Element("DesktopConfig").Attribute("MaximizeText").Value;
            cfg.DesktopConfig.RestoreText = Root.Element("DesktopConfig").Attribute("RestoreText").Value;
            cfg.TaskBar = this.TaskBar();
            cfg.StartMenu = this.StartMenu();
            return cfg;
        }

        private DesktopTaskBar TaskBar()
        {
            var taskBar = new DesktopTaskBar();
            taskBar.CustomConfig.Add(new ConfigItem
            {
                Name = "startBtnText",
                Value = Root.Element("TaskBar").Attribute("StartBtnText").Value,
                Mode = ParameterMode.Value
            });
            taskBar.TrayWidth = 100;
            taskBar.Height = 30;
            taskBar.HideQuickStart = true;
            return taskBar;
        }

        private DesktopStartMenu StartMenu()
        {
            var cfg = new DesktopStartMenu.Config();
            cfg.Title = Root.Element("StartMenu").Attribute("Title").Value;
            cfg.Icon = Icon.Application;
            return new DesktopStartMenu(cfg);
        }

        #endregion

        #region moduleConfig
        public static IEnumerable<DesktopItem> Modules()
        {
            return new DesktopFrame().GetModules();
        }

        private IEnumerable<DesktopItem> GetModules()
        {
            List<DesktopItem> result = new List<DesktopItem>();
            var xModules = doc.Element("Desktop").Element("Modules");
            var items = xModules.Elements("Module");
            foreach (var item in items)
            {
                var desktopItem = new DesktopItem();
                desktopItem.ModuleID = item.Attribute("ModuleID").Value;
                desktopItem.Action = item.Attribute("Action").Value;
                desktopItem.Controller = item.Attribute("Controller").Value;
                desktopItem.Shortcut = Shortcut(item.Element("Shortcut"));
                desktopItem.Launcher = Launcher(item.Element("Launcher"));
                desktopItem.Window = Window(item.Element("Window"));
                result.Add(desktopItem);
            }

            return result;
        }

        private  DesktopShortcut Shortcut(XElement element)
        {
            return new DesktopShortcut
            {
                Name = element.Attribute("Name").Value,
                SortIndex = int.Parse(element.Attribute("SortIndex").Value),
                IconCls = element.Attribute("IconCls").Value
            };
        }
        private  Window Window(XElement element)
        {
            return new Window
            {
                Title = element.Attribute("Title").Value,
                Width = int.Parse(element.Attribute("Width").Value),
                Height = int.Parse(element.Attribute("Height").Value),
                ConstrainHeader = true,
                Plain=true,
                Frame=true,
                Layout = "fit",
                IconCls = element.Attribute("IconCls").Value
            };
        }
        private  MenuItem Launcher(XElement element)
        {
            return new MenuItem
            {
                Text = element.Attribute("Text").Value,
                IconCls = element.Attribute("IconCls").Value
            };
        }

        #endregion
    }

    public class DesktopItem
    {
        public string ModuleID { get; set; }
        public bool AutoRun { get; set; }
        public DesktopShortcut Shortcut { get; set; }
        public MenuItem Launcher { get; set; }
        #region window
        public Window Window { get; set; }

        private WindowItemMode _mode = WindowItemMode.Action;
        public WindowItemMode WindowMode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        public string Action { get; set; }
        public string Controller { get; set; }
        public object RouteValues { get; set; }

        public string PartialName { get; set; }

        public string Path { get; set; }

        public string SertionName { get; set; }
        #endregion

    }
    public enum WindowItemMode
    {
        Action,
        Page,
        Partial,
        Section
    }
}
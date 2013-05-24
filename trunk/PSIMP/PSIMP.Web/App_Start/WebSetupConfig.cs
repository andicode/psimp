using Ext.Net;
using PSIMP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace PSIMP.Web
{
    public class WebSetupConfig
    {
        public static void Start()
        {
            AppConfigContainer cfg = new AppConfigContainer();
            cfg.Database.CreateIfNotExists();

            if (cfg.Menus.Count() == 0)
            {
                InitMenuCgf(cfg);
            }
        }

        private static void InitMenuCgf(AppConfigContainer cfg)
        {
            var root = new Menus();
            root.Name = "首页";
            root.ActionName = "Index";
            root.AreaName = "";
            root.ControllerName = "Home";
            InitPersonMenuCfg(root);
            InitProjectMenuCfg(root);
            InitAdministrationMenuCfg(root);
            InitVehicleMenuCfg(root);
            InitAssetMenuCfg(root);
            InitStatisticsMenuCfg(root);
            cfg.Menus.Add(root);
            cfg.SaveChanges();
        }
        private static void InitPersonMenuCfg(Menus menu)
        {
            var sroot = new Menus();
            sroot.Name = "人员管理";
            sroot.ActionName = "Person";
            sroot.ControllerName = "Home";

            sroot.Items.Add(new Menus { Name = "人员信息", ControllerName = "Person", ActionName = "UI_BaseInfo" });
            sroot.Items.Add(new Menus { Name = "注册信息", ControllerName = "Person", ActionName = "UI_PersonRegister" });
            sroot.Items.Add(new Menus { Name = "证件管理", ControllerName = "Person", ActionName = "UI_PersonCertificateManager" });
            sroot.Items.Add(new Menus { Name = "保险信息", ControllerName = "Person", ActionName = "UI_PersonInsuranceInfo" });
            sroot.Items.Add(new Menus { Name = "合同信息", ControllerName = "Person", ActionName = "UI_PersonContractInfo" });
            menu.Items.Add(sroot);
        }
        private static void InitProjectMenuCfg(Menus menu)
        {
            var sroot = new Menus();
            sroot.Name = "项目管理";
            sroot.ActionName = "Project";
            sroot.ControllerName = "Home";
            menu.Items.Add(sroot);
        }
        private static void InitAdministrationMenuCfg(Menus menu)
        {
            var sroot = new Menus();
            sroot.Name = "行政管理";
            sroot.ActionName = "Administration";
            sroot.ControllerName = "Home";
            menu.Items.Add(sroot);
        }
        private static void InitVehicleMenuCfg(Menus menu)
        {
            var sroot = new Menus();
            sroot.Name = "车辆管理";
            sroot.ActionName = "Vehicle";
            sroot.ControllerName = "Home";
            menu.Items.Add(sroot);
        }
        private static void InitAssetMenuCfg(Menus menu)
        {
            var sroot = new Menus();
            sroot.Name = "设备管理";
            sroot.ActionName = "Asset";
            sroot.ControllerName = "Home";
            menu.Items.Add(sroot);
        }
        private static void InitStatisticsMenuCfg(Menus menu)
        {
            var sroot = new Menus();
            sroot.Name = "统计分析";
            sroot.ActionName = "Statistics";
            sroot.ControllerName = "Home";
            menu.Items.Add(sroot);
        }    
    } 
}
public static class MenuHelper
{
    public static Node GetMenus(this UrlHelper helper)
    {
        AppConfigContainer cfg = new AppConfigContainer();
        var rootMenu = cfg.Menus.SingleOrDefault(m => m.MenusID == null);
        var rootNode = new Node();
        if (rootMenu != null)
            GetnetcMenuNode(rootMenu, rootNode, helper);
        return rootNode;
    }
    private static void GetnetcMenuNode(Menus menu, Node node,UrlHelper url)
    {
        node.NodeID = menu.ID.ToString();
        node.Text = menu.Name;
        node.Href = url.Action(menu.ActionName, menu.ControllerName, new { area = menu.AreaName }) + (menu.Paramater != null ? ("?" + menu.Paramater) : "");
        node.HrefTarget = "_self";
        node.Leaf = menu.Items.Count == 0;
        foreach (var item in menu.Items)
        {
            var child = new Node();
            GetnetcMenuNode(item, child, url);
            node.Children.Add(child);
        }
    }
}
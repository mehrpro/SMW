﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManager.AppForms;
using ShopManager.StructureMapping;

namespace ShopManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Contains("encrypt-config"))
            {
                if (args.Length < 2 || args[1] != "708801298") return;
                var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if (connectionStringSection != null && !connectionStringSection.SectionInformation.IsProtected)
                {
                    connectionStringSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
                config.Save();
                return;
            }
            if (args != null && args.Contains("decrypt-config"))
            {
                if (args.Length < 2 || args[1] != "708801298") return;
                var config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
                if (connectionStringSection != null && connectionStringSection.SectionInformation.IsProtected)
                {
                    connectionStringSection.SectionInformation.UnprotectSection();
                }
                config.Save();
                return;
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new StructureMap.Container(new TypeRegistery());
            var frm = container.GetInstance<LoginForm>();
            frm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(frm);
            if (frm.DialogResult == DialogResult.OK)
            {
                var mainfrm = container.GetInstance<MainForm>();
                mainfrm._container = container;
                mainfrm.ShowDialog();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}

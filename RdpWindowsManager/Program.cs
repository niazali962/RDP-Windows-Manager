﻿using System;
using System.Windows.Forms;
using RdpWindowsManager.Forms;

namespace RdpWindowsManager
{
   internal static class Program
   {
      [STAThread]
      private static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainForm());
      }
   }
}

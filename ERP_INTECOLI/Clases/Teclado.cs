using ERP_INTECOLI.Clases;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Clases.Herramientas
{
    public static class Teclado
    {
        static Process touch_keyboard = new Process();
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        public static void abrirTeclado()
        {
            //Process.Start("TabTip.exe");
            var progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            var keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            //keyboardProc = 
            Process.Start(keyboardPath);
        }

        public static void cerrarTeclado()
        {
            try
            {
                Process[] oskProcessArray = Process.GetProcessesByName("TabTip");
                foreach (Process onscreenProcess in oskProcessArray)
                {
                    onscreenProcess.Kill();
                    onscreenProcess.Dispose();
                }
            }
            catch (Exception)
            {
            }
        }

        public static void cerrarTeclado_security()
        {
            try
            {
                Process[] oskProcessArray = Process.GetProcessesByName("TabTip");
                if (oskProcessArray.Rank > 0)
                {
                    foreach (Process onscreenProcess in oskProcessArray)
                    {
                        onscreenProcess.Kill();
                        onscreenProcess.Dispose();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static void abrirLector()
        {
            try
            {
                ProcessStartInfo pro_lector = new ProcessStartInfo();
                pro_lector.FileName = "C:\\Program Files\\Scanner_OpticonRL\\OpticonRL.exe";
                pro_lector.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(pro_lector);
            }
            catch (Exception ex)
            {
                CajaDialogo.Information(ex.ToString());
            }
        }

        public static void inicializaDiscoImagenes()
        {
            try
            {
                ProcessStartInfo c_imagenes = new ProcessStartInfo();
                c_imagenes.FileName = "K:\\Sistema_Tablet_Taller";
                c_imagenes.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(c_imagenes);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public static bool DriveSetForReconnect()
        {
            RegistryKey key = RegistryKey.OpenRemoteBaseKey (RegistryHive.CurrentUser, Environment.MachineName);

            key = key.OpenSubKey("Network\\" + "K");

            return key != null;
        }

    }
}

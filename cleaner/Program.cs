using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

#pragma warning disable

namespace Cleaner
{
    class Program
    {
        // Constants 
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERD = 0x80000;
        private const int LWA_ALPHA = 0x2;

        // Windows API
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        // Opacity method
        private static void SetConsoleOpacity(byte opacity)
        {
            IntPtr hWnd = GetConsoleWindow();
            int windowLong = GetWindowLong(hWnd, GWL_EXSTYLE);
            SetWindowLong(hWnd, GWL_EXSTYLE, windowLong | WS_EX_LAYERD);
            SetLayeredWindowAttributes(hWnd, 0, opacity, LWA_ALPHA);
        }

        public static string textLogo =
            @"" + Environment.NewLine +
            @"" + Environment.NewLine +
            @"                  ░▒▓██████▓▒░░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓███████▓▒░▒▓████████▓▒░▒▓██████▓▒░░▒▓█▓▒░        " + Environment.NewLine +
            @"                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░         ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        " + Environment.NewLine +
            @"                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░         ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        " + Environment.NewLine +
            @"                 ░▒▓█▓▒░      ░▒▓███████▓▒░ ░▒▓██████▓▒░ ░▒▓██████▓▒░   ░▒▓█▓▒░  ░▒▓████████▓▒░▒▓█▓▒░        " + Environment.NewLine +
            @"                 ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░          ░▒▓█▓▒░  ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        " + Environment.NewLine +
            @"                 ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░          ░▒▓█▓▒░  ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        " + Environment.NewLine +
            @"                  ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓███████▓▒░   ░▒▓█▓▒░  ░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ " + Environment.NewLine +
            @"                                             Made By Cl4vr/2Behindert                                        " + Environment.NewLine;

        static async Task Main(string[] args)
        {
            try
            {
                Console.ResetColor();
                Console.Clear();

                SetConsoleOpacity(245);

                while (true)
                {
                    Console.Clear();
                    Console.Title = "If You Skid This Im Going To Skin You Alive - Cl4vr/2Behindert";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(textLogo);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                       ╔ Functions ══════════════════════════════╗");
                    Console.WriteLine("                                       ║ ----                                    ║");
                    Console.WriteLine("                                       ║ [1] Temp Cleaner                        ║");
                    Console.WriteLine("                                       ║ [2] RecRoom Cleaner                     ║");
                    Console.WriteLine("                                       ║ ----                                    ║");
                    Console.WriteLine("                                       ║ [8] Changelogs                          ║");
                    Console.WriteLine("                                       ║ [9] Credits                             ║");
                    Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                    Console.WriteLine("                                           Enter Your Option And Press Enter      ");
                    Console.WriteLine("                                                      ->                          ");
                    Console.SetCursorPosition(58, 22);

                    // Read input once
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.Clear();
                        string userName = Environment.UserName;
                        string[] directories = new string[]
                        {
                            $@"C:\Users\{userName}\AppData\Local\Temp",
                        };

                        foreach (string dir in directories)
                        {
                            DeleteDirectory(dir);
                        }

                        Console.Clear();
                        Console.WriteLine(textLogo);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Cleaner ════════════════════════════════╗");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ║                   Done!                 ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Cleaner ════════════════════════════════╗");
                        Console.WriteLine("                                       ║        Press Enter To Go Back ->        ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.SetCursorPosition(75, 21);
                        Console.ReadLine();
                    }
                    else if (input == "2")
                    {
                        string userName = Environment.UserName;
                        string[] directories = new string[]
                        {
                            $@"C:\Users\{userName}\AppData\LocalLow\Against Gravity",
                            $@"C:\Users\{userName}\AppData\Local\Temp\RecRoom",
                            $@"C:\Users\{userName}\AppData\Roaming\Microsoft\Windows\Recent\RecRoom.lnk",
                            $@"C:\Users\{userName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Steam\Rec Room.url",
                            @"C:\Windows\Prefetch\RECROOM.EXE-BEC42EED.pf",
                            @"C:\Windows\Prefetch\RECROOM_RELEASE.EXE-35556F3D.pf",
                            $@"{userName}\AppData\Local\Temp\Against Gravity",
                            $@"{userName}\AppData\LocalLow\Against Gravity",
                            $@"{userName}\AppData\Roaming\recroom-launcher",
                            $@"{userName}\AppData\Local\Temp\RecRoom"
                        };

                        foreach (string dir in directories)
                        {
                            DeleteDirectory(dir);
                        }

                        string[] registryKeys = new string[]
                        {
                            @"HKEY_CURRENT_USER\SOFTWARE\Against Gravity",
                            @"HKEY_CURRENT_USER\SOFTWARE\Classes\recroom",
                            @"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\471710",
                            @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 471710",
                            @"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam\Apps\471710",
                            @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\FirewallRules"
                        };

                        foreach (string akey in registryKeys)
                        {
                            DeleteRegistryKey(akey);
                        }

                        Console.Clear();
                        Console.WriteLine(textLogo);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Unlinker ═══════════════════════════════╗");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ║                  DONE!                  ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Options ════════════════════════════════╗");
                        Console.WriteLine("                                       ║        Press Enter To Go Back ->        ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.SetCursorPosition(75, 21);
                        Console.ReadLine();
                    }
                    else if (input == "8")
                    {
                        Console.Clear();
                        Console.WriteLine(textLogo);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                                            Note: This will Change Overtime       ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("                                       ╔ ChangeLogs ═════════════════════════════╗");
                        Console.WriteLine("                                       ║  V1.0 = added Everything Basic Ahh menu ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Options ════════════════════════════════╗");
                        Console.WriteLine("                                       ║        Press Enter To Go Back ->        ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.SetCursorPosition(75, 22);
                        Console.ReadLine();
                    }
                    else if (input == "9")
                    {
                        Console.Clear();
                        Console.WriteLine(textLogo);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Credits ════════════════════════════════╗");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ║       Cl4vr - Main Developer            ║");
                        Console.WriteLine("                                       ║      https://github.com/2Behindert      ║");
                        Console.WriteLine("                                       ║                                         ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.WriteLine("");
                        Console.WriteLine("                                       ╔ Options ════════════════════════════════╗");
                        Console.WriteLine("                                       ║        Press Enter To Go Back ->        ║");
                        Console.WriteLine("                                       ╚═════════════════════════════════════════╝");
                        Console.SetCursorPosition(75, 22);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Press Enter to exit.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }
        }

        static void DeleteRegistryKey(string keyPath)
        {
            try
            {
                RegistryKey baseKey;
                string subKey;

                if (keyPath.StartsWith(@"HKEY_LOCAL_MACHINE\"))
                {
                    baseKey = Registry.LocalMachine;
                    subKey = keyPath.Substring(19); // Remove "HKEY_LOCAL_MACHINE\"
                }
                else if (keyPath.StartsWith(@"HKEY_CURRENT_USER\"))
                {
                    baseKey = Registry.CurrentUser;
                    subKey = keyPath.Substring(18); // Remove "HKEY_CURRENT_USER\"
                }
                else
                {
                    Console.WriteLine($"Invalid registry key path: {keyPath}");
                    return;
                }

                baseKey.DeleteSubKeyTree(subKey, false);
                Console.WriteLine($"Deleted registry key: {keyPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to delete registry key: {keyPath}. Error: {ex.Message}");
            }
        }

        static void DeleteDirectory(string targetDir)
        {
            if (Directory.Exists(targetDir))
            {
                string[] files = Directory.GetFiles(targetDir);
                string[] dirs = Directory.GetDirectories(targetDir);

                foreach (string file in files)
                {
                    try
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine($"Access denied to file: {file}. Skipping.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not delete file: {file}. Error: {ex.Message}");
                    }
                }

                foreach (string dir in dirs)
                {
                    try
                    {
                        DeleteDirectory(dir);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine($"Access denied to directory: {dir}. Skipping.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Could not delete directory: {dir}. Error: {ex.Message}");
                    }
                }

                try
                {
                    Directory.Delete(targetDir, false);
                    Console.WriteLine($"Deleted directory: {targetDir}");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine($"Access denied to directory: {targetDir}. Skipping.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not delete directory: {targetDir}. Error: {ex.Message}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;

namespace Week_3
{
        class FarManager
        {
            public int cursor;
            public string path;
            public int sz;
            public bool ok;
            DirectoryInfo directory = null;
            FileSystemInfo currentFs = null;

            public FarManager()
            {
                cursor = 0;
            }

            public FarManager(string path)
            {
                this.path = path;
                cursor = 0;
                directory = new DirectoryInfo(path);
                sz = directory.GetFileSystemInfos().Length;
                ok = true;
            }

            public void Color(FileSystemInfo fs, int index)
            {
                if (cursor == index)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    currentFs = fs;
                }
                else if (fs.GetType() == typeof(DirectoryInfo))
                {
                Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }

            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                directory = new DirectoryInfo(path);
                FileSystemInfo[] fs = directory.GetFileSystemInfos();
                for (int i = 0, k = 0; i < fs.Length; i++)
                {
                    if (ok == false && fs[i].Name[0] == '.')
                    {
                        continue;
                    }
                    Color(fs[i], k);
                    Console.WriteLine(fs[i].Name);
                    k++;
                }
            }
            public void Up()
            {
                cursor--;
                if (cursor < 0)
                    cursor = sz - 1;
            }
            public void Down()
            {
                cursor++;
                if (cursor == sz)
                    cursor = 0;
            }

            public void CalcSz()
            {
                directory = new DirectoryInfo(path);
                FileSystemInfo[] fs = directory.GetFileSystemInfos();
                sz = fs.Length;
                if (ok == false)
                    for (int i = 0; i < fs.Length; i++)
                        if (fs[i].Name[0] == '.')
                            sz--;
            }

            public static void DeleteDirectory(string deld)
            {
                string[] files = Directory.GetFiles(deld);
                string[] dirs = Directory.GetDirectories(deld);

                foreach (string file in files)
            {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
            }

                foreach (string dir in dirs)
            {
                    DeleteDirectory(dir);
            }

                Directory.Delete(deld, false);
            }

        public void Start()
            {
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                while (consoleKey.Key != ConsoleKey.Escape)
                {
                    CalcSz();
                    Show();
                    consoleKey = Console.ReadKey();
                    if (consoleKey.Key == ConsoleKey.UpArrow)
                        Up();
                    if (consoleKey.Key == ConsoleKey.DownArrow)
                        Down();
                    if (consoleKey.Key == ConsoleKey.RightArrow)
                    {
                        ok = false;
                        cursor = 0;
                    }
                    if (consoleKey.Key == ConsoleKey.LeftArrow)
                    {
                        cursor = 0;
                        ok = true;
                    }
                    if (consoleKey.Key == ConsoleKey.Enter)
                    {
                        if (currentFs.GetType() == typeof(DirectoryInfo))
                        {
                            cursor = 0;
                            path = currentFs.FullName;
                        }
                        else
                        {
                            Process.Start(currentFs.FullName);
                        }
                }
                    if (consoleKey.Key == ConsoleKey.Backspace)
                    {
                        cursor = 0;
                        path = directory.Parent.FullName;
                    }
                    if (consoleKey.Key == ConsoleKey.D)
                    {
                        if (currentFs is DirectoryInfo)
                        {
                            DeleteDirectory(currentFs.FullName);
                        }
                        else
                        {
                            currentFs.Delete();
                        }
                        cursor = 0;

                    }
                    if (consoleKey.Key == ConsoleKey.P)
                    {
                        string oldpath = currentFs.FullName;
                        string newname = Console.ReadLine();

                        Directory.Move(oldpath, path + "/" + newname);

                    }
            }
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                string path = @"C:\Users\Админ\Desktop\pp2";
                FarManager farManager = new FarManager(path);
                farManager.Start();
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace JDF_UI
{
    class Common
    {
        public static Form1 _form1;
        public static Form1 form1 {
            get { return _form1;}
            set{ _form1=value;} 
        }

     

        public static string getRemoteVersion() { 
            WebClient wc=new WebClient();

            string rawData = wc.DownloadString("http://registry.npmjs.org/jdf");

            Regex reg = new Regex("{\"latest.*?}");

            Regex reg1=new Regex("\\d.+\\d");

            string a = reg.Match(rawData).Value;
            var b = reg1.Match(a).Value;

            return b;
             
        
        
        
        }
        public static string getLocationVersion() {
            string result = "";
            //实例化一个进程类
            Process cmd = new Process();

            //获得系统信息，使用的是 systeminfo.exe 这个控制台程序
            cmd.StartInfo.FileName = "cmd.exe";

            //将cmd的标准输入和输出全部重定向到.NET的程序里

            cmd.StartInfo.UseShellExecute = false; //此处必须为false否则引发异常

            cmd.StartInfo.RedirectStandardInput = true; //标准输入
            cmd.StartInfo.RedirectStandardOutput = true; //标准输出
            cmd.StartInfo.RedirectStandardError = true;

            //不显示命令行窗口界面
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            cmd.Start(); //启动进程
            cmd.StandardInput.WriteLine("jdf -v");
            cmd.StandardInput.WriteLine("exit");


            //获取输出
            //需要说明的：此处是指明开始获取，要获取的内容，
            //<span style="color: #FF0000;">只有等进程退出后才能真正拿到</span>
            string resultTxt = cmd.StandardOutput.ReadToEnd();

            cmd.WaitForExit();//等待控制台程序执行完成
            cmd.Close();//关闭该进程

            var arr = System.Text.RegularExpressions.Regex.Split(resultTxt, Environment.NewLine);
            for (int i = 0; i < arr.Length;i++ )
            {
                if (arr[i].Contains("jdf"))
                {
                    result = arr[i + 1].Replace(Environment.NewLine,"").Trim();
                }

            }

            return result;
        
        }
 
    }
}

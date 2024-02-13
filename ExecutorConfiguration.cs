using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace WithdrawerConfiger
{
    public static class ExecutorConfiguration
    {
        public static Serializer Serializer = new Serializer();
        public static Deserializer Deserializer = new Deserializer();

        public static ExecutorConfig CreateDefault(string Identifier, byte CryptKey)
        {
            return new ExecutorConfig()
            {
                Indentifier = FileUtils.ExCode(Identifier, CryptKey, Encoding.UTF8),
                Version = 0,
                Targets = new List<Target>()
                {
                    new Target()
                    {
                        ProcessName = "CHROME",
                        WindowInfo = new WindowInfo()
                        {
                            Title = "CHROME",
                            ClassName = null
                        },
                        ExecutionMethod = ExecutorConsts.ExecutionMethod.RequestClose,
                        Identifier = ExecutorConsts.Identifier.Chrome
                    },
                    new Target()
                    {
                        ProcessName = "MICROSOFT EDGE",
                        WindowInfo = new WindowInfo()
                        {
                            Title = "EDGE",
                            ClassName = null
                        },
                        ExecutionMethod = ExecutorConsts.ExecutionMethod.RequestClose,
                        Identifier = ExecutorConsts.Identifier.Edge
                    },
                    new Target()
                    {
                        ProcessName = "HIPSMAIN",
                        WindowInfo = new WindowInfo()
                        {
                            Title = "火绒安全软件",
                            ClassName = "HLBRMainUI"
                        },
                        ExecutionMethod = ExecutorConsts.ExecutionMethod.RequestClose
                    },
                    new Target()
                    {
                        ProcessName = "MSEDGE",
                        WindowInfo = new WindowInfo()
                        {
                            Title = "EDGE",
                            ClassName = null
                        },
                        ExecutionMethod = ExecutorConsts.ExecutionMethod.RequestClose,
                        Identifier = ExecutorConsts.Identifier.Edge
                    }
                },
                TimeSpans = new List<TimeSpan>()
                {
                    new TimeSpan()
                    {
                        Start = 000000,
                        Finish = 235959
                    }
                },
                DelaySpan = new TimeSpan()
                {
                    Start = 3000,
                    Finish = -1
                },
                UseDaemon = true,
                DaemonInfo = new DaemonInfo()
                {
                    Flag = "Flag"
                }
            };
        }

        public static ExecutorConfig Read(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream ReadStream = new FileStream(path,FileMode.Open,FileAccess.Read))
                {
                    try
                    {
                        byte[] bcontent = new byte[ReadStream.Length];
                        ReadStream.Read(bcontent, 0, bcontent.Length);
                        ReadStream.Close();
                        string content = Encoding.UTF8.GetString(bcontent);
                        return Deserializer.Deserialize<ExecutorConfig>(content);
                    }
                    catch (Exception e)
                    {
                        // Form1.Log(e.Message+"\r\n"+e.StackTrace,"E");
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        
        public static bool Write(ExecutorConfig cfg,string path)
        {
                try
                {
                    using (FileStream WriteStream = new FileStream(path,FileMode.Create,FileAccess.Write))
                    {
                        byte[] bc = Encoding.UTF8.GetBytes(Serializer.Serialize(cfg));
                        WriteStream.Write(bc,0,bc.Length);
                        WriteStream.Close();
                        return true;
                    }
                }
                catch (Exception e)
                {
                    
                    return false;
                }       
        }
    }
}
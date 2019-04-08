using Interface;
using Service;
using System;
using System.IO;
using System.Configuration;
using Unity;


namespace Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("**********简单使用************");
                IUnityContainer container = new UnityContainer();
                container.RegisterType<IHead, Head>();
                container.RegisterType<IMicro, Micro>();
                container.RegisterType<IPower, Power>();
                container.RegisterType<IPhone, IosPhone>();

                IPhone phone = container.Resolve<IPhone>();

                phone.Show();
                
                Console.WriteLine($"phene.Micro is null=={phone.Micro==null}");
                Console.WriteLine($"phene.Head is null=={phone.Head==null}");
                Console.WriteLine($"phene.Power is null=={phone.Power==null}");
            }
            {
                Console.WriteLine("**********依赖注入************");

                IUnityContainer container = new UnityContainer();
                container.RegisterType<IHead, Head>();
                container.RegisterType<IPower, Power>();
                container.RegisterType<IMicro, Micro>();
                container.RegisterType<IPhone, IosPhone>();

                IPhone phone = container.Resolve<IPhone>();

                phone.Show();
                Console.WriteLine($"phene.Micro is null=={phone.Micro == null}");
                Console.WriteLine($"phene.Head is null=={phone.Head == null}");
                Console.WriteLine($"phene.Power is null=={phone.Power == null}");
            }
            {
                Console.WriteLine("**********通过配置文件************");

                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap
                {
                    ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"UnityXml\UnityConfig.xml")
                };
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                //UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

                //IUnityContainer container = new UnityContainer();
                //section.Configure(container, "unityContainer");

            }
            Console.ReadLine();
        }
    }
}

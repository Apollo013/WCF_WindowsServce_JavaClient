# WCF_WindowsServce_JavaClient

A WCF windows hosted service that is accessed via a Java client (dotnet console client available also)

---

Built using VS 2015 Community & Eclipse

---

###Techs & Languages Used
|Tech|
|----|
| C# |
| Java |
| WCF |
| Glassfish Metro |

---

###Installation

####Installation Commands
|Command|Description|
|-------|-----------|
| cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319 | Switches to folder where service can be installed |
|installutil "[YOUR_FOLDER]\WCF_WindowsManagedService\Service\bin\Debug\Service.exe"| Installs the service |
|installutil /u "[YOUR_FOLDER]\WCF_WindowsManagedService\Service\bin\Debug\Service.exe"| Uninstalls the service |
|net start WCFCalculatorService| Starts the service|
|net stop WCFCalculatorService| Stops the service |

####Installation Resources
|Title|Author|Website/Publisher|
|-----|------|-----------------|
|[Metro 2.3.1 Installation](https://metro.java.net/2.3.1/)| | Glassfish |
|[How to install Apache Ant on Windows](https://www.mkyong.com/ant/how-to-install-apache-ant-on-windows/)| mkyong| mkyong.com |

---

###Resources
|Title|Author|Website/Publisher|
|-----|------|-----------------|
|[GlassFish > Metro](https://metro.java.net/)| | Glassfish |
|[Java client and WCF server](http://www.codepool.biz/java-client-and-wcf-server.html)| | DynamSoft |
|[How to: Host a WCF Service in a Managed Windows Service](https://msdn.microsoft.com/en-us/library/ms733069(v=vs.110).aspx)| | MSDN |
|WCF 4.5 Multi-Layer Services Development with Entity Framework (Third Edition)| Mike Liu | PACKT Publishing |


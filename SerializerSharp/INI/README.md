# INI

[Repeat](https://baike.baidu.com/item/ini%E6%96%87%E4%BB%B6/9718973?fr=aladdin)

介绍

.ini 文件是Initialization File的缩写，即初始化文件，是windows的系统配置文件所采用的存储格式，统管windows的各项配置，
一般用户就用windows提供的各项图形化管理界面就可实现相同的配置了。但在某些情况，还是要直接编辑.ini才方便，
一般只有很熟悉windows才能去直接编辑。开始时用于WIN3X下面，WIN95用注册表代替，以及后面的内容表示一个节，相当于注册表中的键。

除了windows2003很多其他操作系统下面的应用软件也有.ini文件，用来配置应用软件以实现不同用户的要求。一般不用直接编辑这些.ini文件，
应用程序的图形界面即可操作以实现相同的功能。它可以用来存放软件信息,注册表信息等。

扩展名

配置文件 .ini

格式

INI文件由节、键、值组成。

节

[section]

参数

（键=值）

name=value

注解

注解使用分号表示（;）。在分号后面的文字，直到该行结尾都全部为注解。
```ini
; comment textINI文件的数据格式的例子（配置文件的内容）　[Section1 Name]
KeyName1=value1
KeyName2=value2
; ...
[Section2 Name]
KeyName21=value21
KeyName22=value22
```
其中：

```[Section1 Name]```用来表示一个段落。

因为INI文件可能是项目中共用的，所以使用```[Section1 Name]```段名来区分不同用途的参数区。

例如：
```[Section1 Name]```表示传感器灵敏度参数区；```[Section2 Name]```表示测量通道参数区等等。

```KeyName1=value1``` 用来表示一个参数名和值。
比如：
```ini
7033=50
7034=51
```
其中：

7033表示某传感器名，50表示它的灵敏度值。

7034表示另一只传感器名，51表示它的灵敏度值。
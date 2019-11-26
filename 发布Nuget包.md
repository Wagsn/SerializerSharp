# 发布Nuget包 只能类库

准备Nuget包有两种方式

- 命令行
  1. 生成Nuget描述文件 .../nuget.exe spec
  2. 生成Nuget包 .../nuget.exe pack [ProjectName].csproj -Build -Properties Configuration=Release
- VS
  1. 右键项目属性
  2. 左侧-打包
  3. 勾选[在构建时生成NuGet包]
  4. 编辑作者公司产品以及说明
  5. 右键项目生成
  6. 文件浏览器打开 .../bin/Debug/[ProjectName].[version].nupkg

发布Nuget包到包管理服务器

.../nuget.exe push [ProjectName].[Version].nupkg [NugetApiKey] -Source http://code.xxxx.com:8081/repository/nuget-hosted/

下面这个不知道怎么用

nuget setapikey [NugetApiKey] -source http://[ip]:[port]/repository/{repository name}/

## 在VS2019上设置Nuget包源

包管理器->右上角设置按钮->弹出选项:Nuget包管理器-程序包源->右上角绿色按钮->编辑名称(随意)和源(http://[ip]:[port]/repository/nuget-hosted/)

## 发布Nuget包到nuget.org

1. 注册登陆到nuget.org
2. Tab-Upload上传Nuget包
3. 头像-APIKeys-Create-选择有效的Nuget包
4. Coby创建好的APIKey
5. 本地执行命令生成和发布Nuget包
```cmd
dotnet build SerializerSharp/SerializerSharp.csproj
dotnet pack SerializerSharp/SerializerSharp.csproj
dotnet nuget push <你的包路径> -k <你的key> -s <需要发布的包源地址>
```
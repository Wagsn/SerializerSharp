# YAML

YAML 文件后缀名 .yml .yaml
大小写敏感

YAML使用冒号加缩进的方式代表层级（属性）关系，使用短横杠(-)代表数组元素。

```yaml
# YAML格式
environments:
    dev:
        url: http://dev.bar.com
        name: Developer Setup
    prod:
        url: http://foo.bar.com
        name: My Cool App
my:
    servers:
        - dev.bar.com
        - foo.bar.com
```

YAML 三种格式的值： 常量值，对象和数组

```yaml
#即表示url属性值；
url: http://www.wolfcode.cn 
#即表示server.host属性的值；
server:
    host: http://www.wolfcode.cn 
#数组，即表示server为[a,b,c]
server:
    - 120.168.117.21
    - 120.168.117.22
    - 120.168.117.23
#常量
pi: 3.14   #定义一个数值3.14
hasChild: true  #定义一个boolean值
name: '你好YAML'   #定义一个字符串
```

1，YAML大小写敏感；
2，使用缩进代表层级关系；
3，缩进只能使用空格，不能使用TAB，不要求空格个数，只需要相同层级左对齐（一般2个或4个空格）

```yaml
key:
    child-key: value
    child-key2: value2
```

YAML中还支持流式(flow)语法表示对象，比如上面例子可以写为：

```yaml
key: {child-key: value, child-key2: value2}
```

较为复杂的对象格式，可以使用问号加一个空格代表一个复杂的key，配合一个冒号加一个空格代表一个value：

```yaml
?  
    - complexkey1
    - complexkey2
:
    - complexvalue1
    - complexvalue2
```

意思即对象的属性是一个数组[complexkey1,complexkey2]，对应的值也是一个数组[complexvalue1,complexvalue2]


```yaml
-
    - Java
    - LOL
```

可以简单理解为：[[Java,LOL]]

```yaml
companies:
    -
        id: 1
        name: company1
        price: 200W
    -
        id: 2
        name: company2
        price: 500W
```

companies: [{id: 1,name: company1,price: 200W},{id: 2,name: company2,price: 500W}]

```yaml
boolean: 
    - TRUE  #true,True都可以
    - FALSE  #false，False都可以
float:
    - 3.14
    - 6.8523015e+5  #可以使用科学计数法
int:
    - 123
    - 0b1010_0111_0100_1010_1110    #二进制表示
null:
    nodeName: 'node'
    parent: ~  #使用~表示null
string:
    - 哈哈
    - 'Hello world'  #可以使用双引号或者单引号包裹特殊字符
    - newline
      newline2    #字符串可以拆成多行，每一行会被转化成一个空格
date:
    - 2018-02-17    #日期必须使用ISO 8601格式，即yyyy-MM-dd
datetime: 
    -  2018-02-17T15:02:31+08:00    #时间使用ISO 8601格式，时间和日期之间使用T连接，最后使用+代表时区
```

YAML in Ruby，Java，Perl，Python，PHP，OCaml，JavaScript, C#
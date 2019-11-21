# YML Why a Markup Language

[Reprint](https://fdik.org/yml/)

Introduction
What is YML?
Well, it's the idea not to need to define a grammar first when you want to use a Domain Specific Language. For that purpose, YML is being translated into XML. Let's make an example.

Everything which comes close to a C like language, parses without a grammar definition:

This:
```yml
template< class T > T max(T a, T b);
```
Parses to:
```xml
<?xml version='1.0' encoding='UTF-8'?>
<template>
  <generic>
    <class/>
    <T/>
  </generic>
  <T>
    <max>
      <parm>
        <T/>
        <a/>
      </parm>
      <parm>
        <T/>
        <b/>
      </parm>
    </max>
  </T>
</template>
```
Instead of defining grammars, you test out and play around until the results are matching your needs. If the resulting tree does not fit what you're expecting, change it by patching the grammar with decl:

This:
```yml
module A {
    interface B {
        attribute long n;
    };
};
```
Parses to:
```xml
<?xml version='1.0' encoding='UTF-8'?>
<module>
  <A>
    <interface>
      <B>
        <attribute>
          <long>
            <n/>
          </long>
        </attribute>
      </B>
    </interface>
  </A>
</module>
```
This does not look like what we want. So we tell YML that we have a module name after the module, an interface name after the interface and type and name after the attribute:

This:
```yml
decl module @name;
decl interface @name;
decl attribute @type @name;

module A {
    interface B {
        attribute long n;
    };
};
```
Parses to:
```xml
<?xml version='1.0' encoding='UTF-8'?>
<module name="A">
  <interface name="B">
    <attribute type="long" name="n"/>
  </interface>
</module>
```
What can I do with YML?
With YML you can:

- use a C-like DSL without writing a grammar first

- generate code out of this DSL using YSLT

- generate code out of UML using YSLT on XMI

- generate code out of any XML based language like SVG using YSLT

- define a wiki like language in just a few lines like YHTML does

- replace bad designed and complicated XML languages with simpler C-like ones

- ... and much more.

How it works: Replacing angle brackets with some Python
Just writing down what I wanted to have instead of XML for a sample:
```xml
<list name="List of goods">
    <head>
        <columTitle>
            Goods
        </columnTitle>
        <columnTitle>
            Price
        </columnTitle>
    </head>
    <row>
        <value>
            Beer
        </value>
        <value>
            20
        </value>
    </row>
    <row>
        <value>
            Wine
        </value>
        <value>
            30
        </value>
    </row>
</list>
```
Something like that should be more easy, say, like this:
```yml
list "List of goods" {
    head title "Goods", title "Price";
    row value "Beer", value 20;
    row value "Wine", value 30;
}
```
Y Languages
The latter is what I call an Y language – a language specified in YML. How could this be achieved? Well, what's to do? To have the required information, how to build XML from the script above, we need:

- the information, that “list of goods” is an attribute named name, while Goods is the text value of a tag
- title shout be written out as columnTitle
How to do that? Let's invent a simple definition language for that information:
```yml
decl list(name);
decl title alias columnTitle;
```
Here you can download the complete list sample.
^Top^ >> Using YML 2 (source)
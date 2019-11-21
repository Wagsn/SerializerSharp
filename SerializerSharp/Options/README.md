# Options

in logstash/config

- jvm.options
- startup.options

```options
-Xms1g
-XX:+HeapDumpOnOutOfMemoryError
-Djava.io.tmpdir=$HOME
-Xloggc:${LS_GC_LOG_FILE}
-Dlog4j2.isThreadContextMapInheritable=true
LS_OPTS="--path.settings ${LS_SETTINGS_DIR}"
JAVACMD=/usr/bin/java
```
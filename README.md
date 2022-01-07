# 后台管理系统

## EFCore生成实体

```c#
Scaffold-DbContext "server=.;userid=tech5_kj;pwd=xxx;port=3306;database=tech5_kj;sslmode=none;" Pomelo.EntityFrameworkCore.MySql -OutputDir Entity -Force
```

### 参数说明

> ```
> -OutputDir *** 实体文件所存放的文件目录
> -ContextDir *** DbContext文件存放的目录
> -Context *** DbContext文件名
> -Schemas *** 需要生成实体数据的数据表所在的模式
> -Tables *** 需要生成实体数据的数据表的集合
> -DataAnnotations
> -UseDatabaseNames 直接使用数据库中的表名和列名（某些版本不支持）
> -Force 强制执行，重写已经存在的实体文件
> ```


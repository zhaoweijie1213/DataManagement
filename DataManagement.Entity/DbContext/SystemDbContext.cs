using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Entity.Entity.System;
using DataManagement.Model.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataManagement.Entity
{
    public partial class SystemDbContext : DbContext
    {
        public SystemDbContext()
        {

        }

        public SystemDbContext(DbContextOptions<SystemDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ConfigGame> ConfigGames { get; set; } = null!;
        public virtual DbSet<ConfigGameArea> ConfigGameAreas { get; set; } = null!;
        public virtual DbSet<ConfigGameCopy> ConfigGameCopies { get; set; } = null!;
        public virtual DbSet<ConfigGameSource> ConfigGameSources { get; set; } = null!;
        public virtual DbSet<ConfigGameType> ConfigGameTypes { get; set; } = null!;
        public virtual DbSet<ConfigItem> ConfigItems { get; set; } = null!;
        public virtual DbSet<ConfigPlacePlay> ConfigPlacePlays { get; set; } = null!;
        public virtual DbSet<ConfigRuleDefinition> ConfigRuleDefinitions { get; set; } = null!;
        public virtual DbSet<ConfigRulevalueDef> ConfigRulevalueDefs { get; set; } = null!;
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistories { get; set; } = null!;
        public virtual DbSet<FnNoticeImage> FnNoticeImages { get; set; } = null!;
        public virtual DbSet<FnNoticeImageCopy> FnNoticeImageCopies { get; set; } = null!;
        public virtual DbSet<GameConsumeLog> GameConsumeLogs { get; set; } = null!;
        public virtual DbSet<GameGameRule> GameGameRules { get; set; } = null!;
        public virtual DbSet<GameGameStartDetail> GameGameStartDetails { get; set; } = null!;
        public virtual DbSet<GameGameStartDiamond> GameGameStartDiamonds { get; set; } = null!;
        public virtual DbSet<GameGameStartLog> GameGameStartLogs { get; set; } = null!;
        public virtual DbSet<GameGameStartRoomCard> GameGameStartRoomCards { get; set; } = null!;
        public virtual DbSet<GameGameStartRule> GameGameStartRules { get; set; } = null!;
        public virtual DbSet<GameGameStartScore> GameGameStartScores { get; set; } = null!;
        public virtual DbSet<GameGameStartUser> GameGameStartUsers { get; set; } = null!;
        public virtual DbSet<GameNewUserLogArea> GameNewUserLogAreas { get; set; } = null!;
        public virtual DbSet<GameNewUserLogCity> GameNewUserLogCities { get; set; } = null!;
        public virtual DbSet<GameNewUserLogGame> GameNewUserLogGames { get; set; } = null!;
        public virtual DbSet<GameNewUserLogProvince> GameNewUserLogProvinces { get; set; } = null!;
        public virtual DbSet<InvitationApplyWdm> InvitationApplyWdms { get; set; } = null!;
        public virtual DbSet<JdEcard> JdEcards { get; set; } = null!;
        public virtual DbSet<LivecodeSy> LivecodeSys { get; set; } = null!;
        public virtual DbSet<LogJuheOrder> LogJuheOrders { get; set; } = null!;
        public virtual DbSet<LogLegueIntegral> LogLegueIntegrals { get; set; } = null!;
        public virtual DbSet<LogRedpackage> LogRedpackages { get; set; } = null!;
        public virtual DbSet<LoginUserPfInfo> LoginUserPfInfos { get; set; } = null!;
        public virtual DbSet<MailItemDrawLog> MailItemDrawLogs { get; set; } = null!;
        public virtual DbSet<MailServerLog> MailServerLogs { get; set; } = null!;
        public virtual DbSet<MailServerUserLog> MailServerUserLogs { get; set; } = null!;
        public virtual DbSet<MailServerUserLogCopy> MailServerUserLogCopies { get; set; } = null!;
        public virtual DbSet<SumConsumeArea> SumConsumeAreas { get; set; } = null!;
        public virtual DbSet<SumConsumeGameType> SumConsumeGameTypes { get; set; } = null!;
        public virtual DbSet<SumGameActiveUser> SumGameActiveUsers { get; set; } = null!;
        public virtual DbSet<SumGameActiveUserApp> SumGameActiveUserApps { get; set; } = null!;
        public virtual DbSet<SumGameActiveUserAppHour> SumGameActiveUserAppHours { get; set; } = null!;
        public virtual DbSet<SumGameActiveUserHour> SumGameActiveUserHours { get; set; } = null!;
        public virtual DbSet<SumGameStart> SumGameStarts { get; set; } = null!;
        public virtual DbSet<SumNewUserArea> SumNewUserAreas { get; set; } = null!;
        public virtual DbSet<SumNewUserCity> SumNewUserCities { get; set; } = null!;
        public virtual DbSet<SumNewUserGame> SumNewUserGames { get; set; } = null!;
        public virtual DbSet<SumNewUserProvince> SumNewUserProvinces { get; set; } = null!;
        public virtual DbSet<SumPlayerGameCount> SumPlayerGameCounts { get; set; } = null!;
        public virtual DbSet<SumPlayerGameCountHour> SumPlayerGameCountHours { get; set; } = null!;
        public virtual DbSet<SumPlayerRetainedArea> SumPlayerRetainedAreas { get; set; } = null!;
        public virtual DbSet<SumPlayerRetainedCity> SumPlayerRetainedCities { get; set; } = null!;
        public virtual DbSet<SumPlayerRetainedGame> SumPlayerRetainedGames { get; set; } = null!;
        public virtual DbSet<SumPlayerRetainedProvince> SumPlayerRetainedProvinces { get; set; } = null!;
        public virtual DbSet<SumRuleUseCount> SumRuleUseCounts { get; set; } = null!;
        public virtual DbSet<SysArticle> SysArticles { get; set; } = null!;
        public virtual DbSet<SysBack> SysBacks { get; set; } = null!;
        public virtual DbSet<SysBack20200513> SysBack20200513s { get; set; } = null!;
        public virtual DbSet<SysBusinessUserRelation> SysBusinessUserRelations { get; set; } = null!;
        public virtual DbSet<SysCity> SysCities { get; set; } = null!;
        public virtual DbSet<SysCounty> SysCounties { get; set; } = null!;
        public virtual DbSet<SysDict> SysDicts { get; set; } = null!;
        public virtual DbSet<SysDictType> SysDictTypes { get; set; } = null!;
        public virtual DbSet<SysEmailLog> SysEmailLogs { get; set; } = null!;
        public virtual DbSet<SysLoginLog> SysLoginLogs { get; set; } = null!;
        public virtual DbSet<SysMenu> SysMenus { get; set; } = null!;
        public virtual DbSet<SysMenu20190929> SysMenu20190929s { get; set; } = null!;
        public virtual DbSet<SysMenu20191113> SysMenu20191113s { get; set; } = null!;
        public virtual DbSet<SysMenu20200513> SysMenu20200513s { get; set; } = null!;
        public virtual DbSet<SysMenu20211210> SysMenu20211210s { get; set; } = null!;
        public virtual DbSet<SysMerge> SysMerges { get; set; } = null!;
        public virtual DbSet<SysParameter> SysParameters { get; set; } = null!;
        public virtual DbSet<SysProvince> SysProvinces { get; set; } = null!;
        public virtual DbSet<SysRole> SysRoles { get; set; } = null!;
        public virtual DbSet<SysRoleBtn> SysRoleBtns { get; set; } = null!;
        public virtual DbSet<SysRoleGame> SysRoleGames { get; set; } = null!;
        public virtual DbSet<SysRoleMenu> SysRoleMenus { get; set; } = null!;
        public virtual DbSet<SysRoleUser> SysRoleUsers { get; set; } = null!;
        public virtual DbSet<SysSlide> SysSlides { get; set; } = null!;
        public virtual DbSet<SysSmsConfig> SysSmsConfigs { get; set; } = null!;
        public virtual DbSet<SysSystemLog> SysSystemLogs { get; set; } = null!;
        public virtual DbSet<SysUser> SysUsers { get; set; } = null!;
        public virtual DbSet<SysUserBtn> SysUserBtns { get; set; } = null!;
        public virtual DbSet<SysUserGame> SysUserGames { get; set; } = null!;
        public virtual DbSet<SysUserMenu> SysUserMenus { get; set; } = null!;
        public virtual DbSet<SysUserWechat> SysUserWechats { get; set; } = null!;
        public virtual DbSet<UtilLivecode> UtilLivecodes { get; set; } = null!;
        public virtual DbSet<UtilSendMsg> UtilSendMsgs { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseMySql("server=192.168.0.213;database=mj_log3;uid=root;pwd=B85Jqcy7EZT^2CT;charset=utf8;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.28-mysql"));
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<ConfigGame>(entity =>
            {
                entity.ToTable("config_game");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationMaxPrice)
                    .HasPrecision(10, 2)
                    .HasColumnName("activationMaxPrice")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("激活最大金额");

                entity.Property(e => e.ActivationMinPrice)
                    .HasPrecision(10, 2)
                    .HasColumnName("activationMinPrice")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("激活最小金额");

                entity.Property(e => e.BusinessWeChat)
                    .HasMaxLength(500)
                    .HasColumnName("businessWeChat")
                    .HasDefaultValueSql("''")
                    .HasComment("商务专员微信");

                entity.Property(e => e.ContainsCode)
                    .HasMaxLength(255)
                    .HasColumnName("containsCode")
                    .HasDefaultValueSql("''")
                    .HasComment("PF");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.DefaultLevel)
                    .HasMaxLength(255)
                    .HasColumnName("defaultLevel")
                    .HasDefaultValueSql("''")
                    .HasComment("默认代理等级");

                entity.Property(e => e.DownLoadQrcodeUrl)
                    .HasMaxLength(255)
                    .HasColumnName("downLoadQRCodeUrl")
                    .HasDefaultValueSql("''")
                    .HasComment("二维码");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.IsAutoAudit)
                    .HasColumnType("int(11)")
                    .HasColumnName("isAutoAudit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("自动审核");

                entity.Property(e => e.IsOpenDistribution)
                    .HasColumnType("int(11)")
                    .HasColumnName("isOpenDistribution")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否开启三级分销");

                entity.Property(e => e.IsShare)
                    .HasColumnType("int(11)")
                    .HasColumnName("isShare")
                    .HasDefaultValueSql("'0'")
                    .HasComment("默认代理等级是否分享");

                entity.Property(e => e.Iscommon)
                    .HasColumnType("int(11)")
                    .HasColumnName("iscommon")
                    .HasDefaultValueSql("'0'")
                    .HasComment("0是不通用 1是通用 通用适用于所有地区");

                entity.Property(e => e.Levelssysno)
                    .HasMaxLength(1000)
                    .HasColumnName("levelssysno")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Levelstitle)
                    .HasMaxLength(1000)
                    .HasColumnName("levelstitle")
                    .HasDefaultValueSql("''")
                    .HasComment("可用代理等级");

                entity.Property(e => e.LimitMaxPrice)
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasColumnName("limitMaxPrice")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("限购金额");

                entity.Property(e => e.LogUrl)
                    .HasMaxLength(255)
                    .HasColumnName("logUrl")
                    .HasDefaultValueSql("''")
                    .HasComment("LOGO");

                entity.Property(e => e.OpenGameIds)
                    .HasMaxLength(255)
                    .HasColumnName("openGameIds")
                    .HasDefaultValueSql("''")
                    .HasComment("开通通用游戏");

                entity.Property(e => e.ParentCodeNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("parentCodeNo")
                    .HasComment("大厅编号");

                entity.Property(e => e.ProductPicture)
                    .HasMaxLength(255)
                    .HasColumnName("productPicture")
                    .HasDefaultValueSql("''")
                    .HasComment("产品图片");

                entity.Property(e => e.RebateProportion)
                    .HasPrecision(10, 2)
                    .HasColumnName("rebateProportion")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("不推荐代理返利");

                entity.Property(e => e.RebateProportion1)
                    .HasPrecision(10, 2)
                    .HasColumnName("rebateProportion1")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("一级代理返利");

                entity.Property(e => e.RebateProportion2)
                    .HasPrecision(10, 2)
                    .HasColumnName("rebateProportion2")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("二级代理返利");

                entity.Property(e => e.RechargeMaxPrice)
                    .HasPrecision(10, 2)
                    .HasColumnName("rechargeMaxPrice")
                    .HasComment("充值最大金额");

                entity.Property(e => e.RechargeMinPrice)
                    .HasPrecision(10, 2)
                    .HasColumnName("rechargeMinPrice")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("充值最小金额");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<ConfigGameArea>(entity =>
            {
                entity.ToTable("config_gameArea");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<ConfigGameCopy>(entity =>
            {
                entity.ToTable("config_game_copy");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationMaxPrice)
                    .HasPrecision(10, 2)
                    .HasColumnName("activationMaxPrice")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("激活最大金额");

                entity.Property(e => e.ActivationMinPrice)
                    .HasPrecision(10, 2)
                    .HasColumnName("activationMinPrice")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("激活最小金额");

                entity.Property(e => e.BusinessWeChat)
                    .HasMaxLength(500)
                    .HasColumnName("businessWeChat")
                    .HasDefaultValueSql("''")
                    .HasComment("商务专员微信");

                entity.Property(e => e.ContainsCode)
                    .HasMaxLength(255)
                    .HasColumnName("containsCode")
                    .HasDefaultValueSql("''")
                    .HasComment("PF");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.DefaultLevel)
                    .HasMaxLength(255)
                    .HasColumnName("defaultLevel")
                    .HasDefaultValueSql("''")
                    .HasComment("默认代理等级");

                entity.Property(e => e.DownLoadQrcodeUrl)
                    .HasMaxLength(255)
                    .HasColumnName("downLoadQRCodeUrl")
                    .HasDefaultValueSql("''")
                    .HasComment("二维码");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.IsAutoAudit)
                    .HasColumnType("int(11)")
                    .HasColumnName("isAutoAudit")
                    .HasDefaultValueSql("'0'")
                    .HasComment("自动审核");

                entity.Property(e => e.IsOpenDistribution)
                    .HasColumnType("int(11)")
                    .HasColumnName("isOpenDistribution")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否开启三级分销");

                entity.Property(e => e.IsShare)
                    .HasColumnType("int(11)")
                    .HasColumnName("isShare")
                    .HasDefaultValueSql("'0'")
                    .HasComment("默认代理等级是否分享");

                entity.Property(e => e.Iscommon)
                    .HasColumnType("int(11)")
                    .HasColumnName("iscommon")
                    .HasDefaultValueSql("'0'")
                    .HasComment("0是不通用 1是通用 通用适用于所有地区");

                entity.Property(e => e.Levelssysno)
                    .HasMaxLength(1000)
                    .HasColumnName("levelssysno")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Levelstitle)
                    .HasMaxLength(1000)
                    .HasColumnName("levelstitle")
                    .HasDefaultValueSql("''")
                    .HasComment("可用代理等级");

                entity.Property(e => e.LimitMaxPrice)
                    .HasColumnType("decimal(10,2) unsigned")
                    .HasColumnName("limitMaxPrice")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("限购金额");

                entity.Property(e => e.LogUrl)
                    .HasMaxLength(255)
                    .HasColumnName("logUrl")
                    .HasDefaultValueSql("''")
                    .HasComment("LOGO");

                entity.Property(e => e.OpenGameIds)
                    .HasMaxLength(255)
                    .HasColumnName("openGameIds")
                    .HasDefaultValueSql("''")
                    .HasComment("开通通用游戏");

                entity.Property(e => e.ParentCodeNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("parentCodeNo")
                    .HasComment("大厅编号");

                entity.Property(e => e.ProductPicture)
                    .HasMaxLength(255)
                    .HasColumnName("productPicture")
                    .HasDefaultValueSql("''")
                    .HasComment("产品图片");

                entity.Property(e => e.RebateProportion)
                    .HasPrecision(10, 2)
                    .HasColumnName("rebateProportion")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("不推荐代理返利");

                entity.Property(e => e.RebateProportion1)
                    .HasPrecision(10, 2)
                    .HasColumnName("rebateProportion1")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("一级代理返利");

                entity.Property(e => e.RebateProportion2)
                    .HasPrecision(10, 2)
                    .HasColumnName("rebateProportion2")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("二级代理返利");

                entity.Property(e => e.RechargeMaxPrice)
                    .HasPrecision(10, 2)
                    .HasColumnName("rechargeMaxPrice")
                    .HasComment("充值最大金额");

                entity.Property(e => e.RechargeMinPrice)
                    .HasPrecision(10, 2)
                    .HasColumnName("rechargeMinPrice")
                    .HasDefaultValueSql("'0.00'")
                    .HasComment("充值最小金额");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<ConfigGameSource>(entity =>
            {
                entity.ToTable("config_gameSource");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type")
                    .HasComment("1：app大厅，2：h5大厅");
            });

            modelBuilder.Entity<ConfigGameType>(entity =>
            {
                entity.ToTable("config_gameType");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Codeno)
                    .HasColumnType("int(11)")
                    .HasColumnName("codeno");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .UseCollation("utf8mb4_general_ci")
                    .HasCharSet("utf8mb4");
            });

            modelBuilder.Entity<ConfigItem>(entity =>
            {
                entity.ToTable("config_item");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Affairs)
                    .HasColumnType("int(1)")
                    .HasColumnName("affairs")
                    .HasComment("商务可用");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid")
                    .HasComment("大厅id");

                entity.Property(e => e.CanEquip)
                    .HasColumnType("int(1)")
                    .HasColumnName("canEquip")
                    .HasComment("可否装备");

                entity.Property(e => e.Describe)
                    .HasMaxLength(255)
                    .HasColumnName("describe")
                    .HasComment("描述");

                entity.Property(e => e.DiamondPrice)
                    .HasColumnType("int(11)")
                    .HasColumnName("diamondPrice")
                    .HasComment("钻石估价");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid")
                    .HasComment("游戏id");

                entity.Property(e => e.GiveAble)
                    .HasColumnType("int(1)")
                    .HasColumnName("giveAble")
                    .HasComment("可否赠送");

                entity.Property(e => e.Icon)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon")
                    .HasComment("图标");

                entity.Property(e => e.IsAllShow)
                    .HasColumnType("int(1)")
                    .HasColumnName("isAllShow")
                    .HasComment("是否通用");

                entity.Property(e => e.IsMerge)
                    .HasColumnType("int(1)")
                    .HasColumnName("isMerge")
                    .HasComment("可否合成");

                entity.Property(e => e.IsUnique)
                    .HasColumnType("int(1)")
                    .HasColumnName("isUnique")
                    .HasComment("是否唯一");

                entity.Property(e => e.Isshow)
                    .HasColumnType("int(1)")
                    .HasColumnName("isshow")
                    .HasComment("是否显示（后台使用）");

                entity.Property(e => e.Itemid)
                    .HasColumnType("int(11)")
                    .HasColumnName("itemid")
                    .HasComment("道具id");

                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level")
                    .HasComment("人物等级限制");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasComment("道具名称");

                entity.Property(e => e.OrderPriority)
                    .HasColumnType("int(11)")
                    .HasColumnName("orderPriority")
                    .HasComment("排序优先级");

                entity.Property(e => e.Quality)
                    .HasMaxLength(255)
                    .HasColumnName("quality")
                    .HasComment("品质");

                entity.Property(e => e.SellPrice)
                    .HasColumnType("int(11)")
                    .HasColumnName("sellPrice")
                    .HasComment("出售价格");

                entity.Property(e => e.Type)
                    .HasColumnType("int(1)")
                    .HasColumnName("type")
                    .HasComment("类型");

                entity.Property(e => e.UseDiamond)
                    .HasColumnType("int(11)")
                    .HasColumnName("useDiamond")
                    .HasComment("使用获得钻石");

                entity.Property(e => e.UseItem)
                    .HasColumnType("int(11)")
                    .HasColumnName("useItem")
                    .HasComment("使用获得道具");

                entity.Property(e => e.UseMoney)
                    .HasColumnType("int(11)")
                    .HasColumnName("useMoney")
                    .HasComment("使用获得金币");

                entity.Property(e => e.UsePhone)
                    .HasColumnType("int(11)")
                    .HasColumnName("usePhone")
                    .HasComment("使用获得礼券");

                entity.Property(e => e.VipLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("vipLevel")
                    .HasComment("VIP等级限制");
            });

            modelBuilder.Entity<ConfigPlacePlay>(entity =>
            {
                entity.ToTable("config_placePlay");

                entity.HasComment("地区玩法")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Codeno)
                    .HasColumnType("int(11)")
                    .HasColumnName("codeno");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<ConfigRuleDefinition>(entity =>
            {
                entity.ToTable("config_ruleDefinition");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CnDef)
                    .HasMaxLength(255)
                    .HasColumnName("CN_def")
                    .HasComment("中文定义");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.ProgramDef)
                    .HasMaxLength(255)
                    .HasColumnName("Program_def")
                    .HasComment("程序定义");
            });

            modelBuilder.Entity<ConfigRulevalueDef>(entity =>
            {
                entity.ToTable("config_rulevalueDef");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CnRulevalue)
                    .HasMaxLength(255)
                    .HasColumnName("CN_rulevalue");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(32)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Rulename)
                    .HasMaxLength(255)
                    .HasColumnName("rulename");

                entity.Property(e => e.Rulevalue)
                    .HasMaxLength(255)
                    .HasColumnName("rulevalue");
            });

            modelBuilder.Entity<EfmigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__EFMigrationsHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<FnNoticeImage>(entity =>
            {
                entity.ToTable("fn_noticeImage");

                entity.HasIndex(e => e.Appid, "appid");

                entity.HasIndex(e => e.Gameid, "gameid");

                entity.HasIndex(e => e.State, "state");

                entity.HasIndex(e => e.Type, "type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Activetype)
                    .HasColumnType("int(11)")
                    .HasColumnName("activetype")
                    .HasComment("动作编号");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid")
                    .HasComment("大厅id");

                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .HasColumnName("content")
                    .HasDefaultValueSql("''")
                    .HasComment("内容描述")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime")
                    .HasComment("创建时间");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid")
                    .HasComment("游戏id或者地区id");

                entity.Property(e => e.Imagesort)
                    .HasColumnType("int(11)")
                    .HasColumnName("imagesort")
                    .HasDefaultValueSql("'0'")
                    .HasComment("图片排序");

                entity.Property(e => e.Imgsrc)
                    .HasMaxLength(255)
                    .HasColumnName("imgsrc")
                    .HasDefaultValueSql("''")
                    .HasComment("图片地址")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pf)
                    .HasMaxLength(20)
                    .HasColumnName("pf")
                    .HasComment("大厅")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasComment("状态");

                entity.Property(e => e.Tableid)
                    .HasColumnType("int(11)")
                    .HasColumnName("tableid")
                    .HasDefaultValueSql("'0'")
                    .HasComment("比赛场编号");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type")
                    .HasComment("类型，1大厅图片");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url")
                    .HasDefaultValueSql("''")
                    .HasComment("跳转链接");
            });

            modelBuilder.Entity<FnNoticeImageCopy>(entity =>
            {
                entity.ToTable("fn_noticeImage_copy");

                entity.HasIndex(e => e.Appid, "appid");

                entity.HasIndex(e => e.Gameid, "gameid");

                entity.HasIndex(e => e.State, "state");

                entity.HasIndex(e => e.Type, "type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Activetype)
                    .HasColumnType("int(11)")
                    .HasColumnName("activetype")
                    .HasComment("动作编号");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid")
                    .HasComment("大厅id");

                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .HasColumnName("content")
                    .HasDefaultValueSql("''")
                    .HasComment("内容描述")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime")
                    .HasComment("创建时间");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid")
                    .HasComment("游戏id或者地区id");

                entity.Property(e => e.Imagesort)
                    .HasColumnType("int(11)")
                    .HasColumnName("imagesort")
                    .HasComment("图片排序");

                entity.Property(e => e.Imgsrc)
                    .HasMaxLength(255)
                    .HasColumnName("imgsrc")
                    .HasDefaultValueSql("''")
                    .HasComment("图片地址")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Pf)
                    .HasMaxLength(20)
                    .HasColumnName("pf")
                    .HasComment("大厅")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasComment("状态");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type")
                    .HasComment("类型，1大厅图片");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url")
                    .HasDefaultValueSql("''")
                    .HasComment("跳转链接");
            });

            modelBuilder.Entity<GameConsumeLog>(entity =>
            {
                entity.ToTable("game_consumeLog");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_unicode_ci");

                entity.HasIndex(e => e.Gameid, "game_id");

                entity.HasIndex(e => e.Gameno, "num");

                entity.HasIndex(e => new { e.Provinceid, e.Cityid, e.Countyid, e.Gameid, e.Date }, "updated");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areadiamond)
                    .HasColumnType("int(11)")
                    .HasColumnName("areadiamond")
                    .HasDefaultValueSql("'0'")
                    .HasComment("地区钻石");

                entity.Property(e => e.Areatype)
                    .HasColumnType("int(11)")
                    .HasColumnName("areatype");

                entity.Property(e => e.Cardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("cardcount");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Clubid)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubid");

                entity.Property(e => e.Costclubcard)
                    .HasColumnType("int(11)")
                    .HasColumnName("costclubcard");

                entity.Property(e => e.Costuid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("costuid");

                entity.Property(e => e.Countyid)
                    .HasColumnType("int(11)")
                    .HasColumnName("countyid");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Diamond)
                    .HasColumnType("int(11)")
                    .HasColumnName("diamond");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(4)")
                    .HasColumnName("gameid")
                    .HasComment("游戏区域");

                entity.Property(e => e.Gameno)
                    .HasMaxLength(50)
                    .HasColumnName("gameno")
                    .HasComment("游戏流水号");

                entity.Property(e => e.Gametype)
                    .HasColumnType("int(4)")
                    .HasColumnName("gametype")
                    .HasComment("游戏县级");

                entity.Property(e => e.Gecardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("gecardcount")
                    .HasComment("通用房卡数量");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Roomkey)
                    .HasMaxLength(10)
                    .HasColumnName("roomkey");

                entity.Property(e => e.Roomtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("roomtype")
                    .HasComment("几人房");
            });

            modelBuilder.Entity<GameGameRule>(entity =>
            {
                entity.ToTable("game_gameRule");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Codeno)
                    .HasColumnType("int(11)")
                    .HasColumnName("codeno")
                    .HasComment("规则编号");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime")
                    .HasComment("创建时间");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid")
                    .HasComment("游戏id");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasComment("规则名称");
            });

            modelBuilder.Entity<GameGameStartDetail>(entity =>
            {
                entity.ToTable("game_gameStartDetail");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("endtime")
                    .HasComment("结束时间");

                entity.Property(e => e.Gamenum)
                    .HasColumnType("int(11)")
                    .HasColumnName("gamenum")
                    .HasComment("第几局");

                entity.Property(e => e.Logid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("logid")
                    .HasComment("日志id");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("starttime")
                    .HasComment("开始时间");
            });

            modelBuilder.Entity<GameGameStartDiamond>(entity =>
            {
                entity.ToTable("game_gameStartDiamond");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Logid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("logid");
            });

            modelBuilder.Entity<GameGameStartLog>(entity =>
            {
                entity.ToTable("game_gameStartLog");

                entity.HasComment("游戏日志表\r\n说明：记录游戏开局信息，其中包含游戏开局基本信息，此表用于原型图（游戏开局，根据gameid统计APP和小游戏）统计")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Provinceid, "app_index");

                entity.HasIndex(e => new { e.Clubid, e.Endtime, e.Gameid }, "clubid_gameid");

                entity.HasIndex(e => new { e.Roomuid, e.Clubid, e.Endtime, e.Gameid }, "clubid_uid_endtime");

                entity.HasIndex(e => e.Endtime, "endtime");

                entity.HasIndex(e => e.Gameid, "game_index");

                entity.HasIndex(e => new { e.Gameid, e.Endtime }, "gameid_endtime");

                entity.HasIndex(e => new { e.Gameno, e.Gameid }, "gameno_gameid");

                entity.HasIndex(e => e.Matchstate, "matchstate");

                entity.HasIndex(e => e.Roomkey, "roomkey");

                entity.HasIndex(e => e.Starttime, "starttime");

                entity.HasIndex(e => e.Roomuid, "uid_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid")
                    .HasComment("区域ID");

                entity.Property(e => e.Begininnings)
                    .HasColumnType("int(11)")
                    .HasColumnName("begininnings")
                    .HasComment("游戏开局数");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid")
                    .HasComment("地市级ID");

                entity.Property(e => e.Clubid)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubid")
                    .HasComment("俱乐部ID");

                entity.Property(e => e.Costclubcard)
                    .HasColumnType("int(11)")
                    .HasColumnName("costclubcard")
                    .HasComment("是否消耗俱乐部房卡");

                entity.Property(e => e.Createuid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("createuid")
                    .HasComment("开房人uid");

                entity.Property(e => e.Endinnings)
                    .HasColumnType("int(11)")
                    .HasColumnName("endinnings")
                    .HasComment("游戏完成了的局数");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("endtime")
                    .HasComment("游戏结束时间");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid")
                    .HasComment("小游戏id");

                entity.Property(e => e.Gameno)
                    .HasMaxLength(50)
                    .HasColumnName("gameno")
                    .HasDefaultValueSql("'0'")
                    .HasComment("游戏局流水号")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Gametype)
                    .HasColumnType("int(11)")
                    .HasColumnName("gametype")
                    .HasComment("游戏类型（4局，8局）");

                entity.Property(e => e.Istake)
                    .HasColumnType("bit(1)")
                    .HasColumnName("istake")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("是否代开房");

                entity.Property(e => e.Matchstate)
                    .HasColumnType("int(11)")
                    .HasColumnName("matchstate")
                    .HasComment("开局状态");

                entity.Property(e => e.Placeplay)
                    .HasColumnType("int(11)")
                    .HasColumnName("placeplay")
                    .HasComment("地方打法");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid")
                    .HasComment("省份ID");

                entity.Property(e => e.Roomkey)
                    .HasMaxLength(50)
                    .HasColumnName("roomkey")
                    .HasComment("房间号")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Roomtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("roomtype")
                    .HasComment("房间类型（几人）");

                entity.Property(e => e.Roomuid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("roomuid")
                    .HasComment("房主ID");

                entity.Property(e => e.Serverid)
                    .HasColumnType("int(11)")
                    .HasColumnName("serverid")
                    .HasComment("服务器id");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("starttime")
                    .HasComment("游戏开始时间");

                entity.Property(e => e.Takename)
                    .HasMaxLength(255)
                    .HasColumnName("takename")
                    .HasComment("代开房名称");

                entity.Property(e => e.Takeuid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("takeuid")
                    .HasComment("代开房uid");
            });

            modelBuilder.Entity<GameGameStartRoomCard>(entity =>
            {
                entity.ToTable("game_gameStartRoomCard");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Logid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("logid");
            });

            modelBuilder.Entity<GameGameStartRule>(entity =>
            {
                entity.ToTable("game_gameStartRule");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Logid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("logid");

                entity.Property(e => e.Rulename)
                    .HasMaxLength(255)
                    .HasColumnName("rulename");

                entity.Property(e => e.Rulevalue)
                    .HasMaxLength(255)
                    .HasColumnName("rulevalue");
            });

            modelBuilder.Entity<GameGameStartScore>(entity =>
            {
                entity.ToTable("game_gameStartScore");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Detailid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("detailid");

                entity.Property(e => e.Scoreall)
                    .HasColumnType("int(11)")
                    .HasColumnName("scoreall");

                entity.Property(e => e.Scorechange)
                    .HasColumnType("int(11)")
                    .HasColumnName("scorechange");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<GameGameStartUser>(entity =>
            {
                entity.ToTable("game_gameStartUser");

                entity.HasIndex(e => e.Logid, "logid");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Logid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("logid");

                entity.Property(e => e.Scoreall)
                    .HasColumnType("int(11)")
                    .HasColumnName("scoreall");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<GameNewUserLogArea>(entity =>
            {
                entity.ToTable("game_newUserLogArea");

                entity.HasIndex(e => new { e.Provinceid, e.Cityid, e.Areaid }, "provinceid_cityid_areaid");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<GameNewUserLogCity>(entity =>
            {
                entity.ToTable("game_newUserLogCity");

                entity.HasIndex(e => new { e.Provinceid, e.Cityid }, "provinceid_cityid");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<GameNewUserLogGame>(entity =>
            {
                entity.ToTable("game_newUserLogGame");

                entity.HasIndex(e => new { e.Provinceid, e.Cityid, e.Areaid, e.Gameid }, "provinceid_cityid_areaid_gameid");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<GameNewUserLogProvince>(entity =>
            {
                entity.ToTable("game_newUserLogProvince");

                entity.HasIndex(e => e.Provinceid, "provinceid");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<InvitationApplyWdm>(entity =>
            {
                entity.ToTable("invitation_apply_wdm");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("编号");

                entity.Property(e => e.Applyid)
                    .HasColumnType("int(11)")
                    .HasColumnName("applyid")
                    .HasComment("申请id");

                entity.Property(e => e.Approver)
                    .HasMaxLength(20)
                    .HasColumnName("approver")
                    .HasComment("审批人");

                entity.Property(e => e.Approvtime)
                    .HasColumnType("datetime")
                    .HasColumnName("approvtime")
                    .HasComment("审批时间");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid")
                    .HasComment("区域id");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime")
                    .HasComment("时间");

                entity.Property(e => e.Curaveragemovie)
                    .HasColumnType("int(11)")
                    .HasColumnName("curaveragemovie")
                    .HasComment("当前平均观看广告次数");

                entity.Property(e => e.Curplayernum)
                    .HasColumnType("int(11)")
                    .HasColumnName("curplayernum")
                    .HasComment("当前邀请人数");

                entity.Property(e => e.Curtotalmovienum)
                    .HasColumnType("int(11)")
                    .HasColumnName("curtotalmovienum")
                    .HasComment("当前观看总广告次数");

                entity.Property(e => e.Itemcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("itemcount")
                    .HasComment("数量");

                entity.Property(e => e.Itemtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("itemtype")
                    .HasComment("类型");

                entity.Property(e => e.Needaveragemovie)
                    .HasColumnType("int(11)")
                    .HasColumnName("needaveragemovie")
                    .HasComment("需要平均观看广告次数");

                entity.Property(e => e.Needpalyernum)
                    .HasColumnType("int(11)")
                    .HasColumnName("needpalyernum")
                    .HasComment("需要邀请人数");

                entity.Property(e => e.Needtotalmovienum)
                    .HasColumnType("int(11)")
                    .HasColumnName("needtotalmovienum")
                    .HasComment("需要观看总广告次数");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone")
                    .HasComment("电话");

                entity.Property(e => e.Playerid)
                    .HasColumnType("int(11)")
                    .HasColumnName("playerid")
                    .HasComment("玩家id");

                entity.Property(e => e.Result)
                    .HasColumnType("int(11)")
                    .HasColumnName("result")
                    .HasComment("申请结果 1同意 2拒绝");

                entity.Property(e => e.Source)
                    .HasColumnType("int(11)")
                    .HasColumnName("source")
                    .HasComment("来源");

                entity.Property(e => e.Usedpalyernum)
                    .HasColumnType("int(11)")
                    .HasColumnName("usedpalyernum")
                    .HasComment("消耗人数");
            });

            modelBuilder.Entity<JdEcard>(entity =>
            {
                entity.ToTable("jdECard");

                entity.HasIndex(e => new { e.Money, e.State }, "money");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Cardid)
                    .HasMaxLength(32)
                    .HasColumnName("cardid")
                    .HasComment("卡号");

                entity.Property(e => e.Cardpass)
                    .HasMaxLength(32)
                    .HasColumnName("cardpass")
                    .HasComment("E卡密码");

                entity.Property(e => e.Money)
                    .HasColumnType("int(5)")
                    .HasColumnName("money")
                    .HasComment("面额");

                entity.Property(e => e.State)
                    .HasColumnType("int(5)")
                    .HasColumnName("state")
                    .HasComment("使用状态:未使用0已使用1");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time")
                    .HasComment("有效时间");

                entity.Property(e => e.Usetime)
                    .HasColumnType("datetime")
                    .HasColumnName("usetime")
                    .HasComment("创建时间");
            });

            modelBuilder.Entity<LivecodeSy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("livecodeSys");

                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaId");

                entity.Property(e => e.CreateTime).HasColumnName("createTime");

                entity.Property(e => e.GameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameId");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SysNo)
                    .HasMaxLength(32)
                    .HasColumnName("sysNo");

                entity.Property(e => e.UtilCodeUrl)
                    .HasMaxLength(255)
                    .HasColumnName("utilCodeUrl");

                entity.Property(e => e.UtilName)
                    .HasMaxLength(255)
                    .HasColumnName("utilName");
            });

            modelBuilder.Entity<LogJuheOrder>(entity =>
            {
                entity.ToTable("log_juheOrder");

                entity.HasIndex(e => e.Createtime, "createtime");

                entity.HasIndex(e => e.JuheOrderId, "juheOrderId");

                entity.HasIndex(e => e.ProductId, "productId");

                entity.HasIndex(e => e.ProductType, "productType");

                entity.HasIndex(e => e.Tel, "tel");

                entity.HasIndex(e => new { e.Uid, e.Areaid }, "uid");

                entity.HasIndex(e => e.UserOrderId, "userOrderId");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Agentsysno)
                    .HasMaxLength(32)
                    .HasColumnName("agentsysno")
                    .HasDefaultValueSql("''")
                    .HasComment("代理商编号，为空时是玩家充值");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .HasColumnName("cardNo")
                    .HasComment("加密后的卡号，type1时的字段");

                entity.Property(e => e.CardPws)
                    .HasMaxLength(50)
                    .HasColumnName("cardPws")
                    .HasComment("加密后的卡密，type1时的字段");

                entity.Property(e => e.Costticket)
                    .HasColumnType("int(11)")
                    .HasColumnName("costticket")
                    .HasComment("消耗的兑换券");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.ExpireDate)
                    .HasMaxLength(50)
                    .HasColumnName("expireDate")
                    .HasComment("失效时间，type1时的字段");

                entity.Property(e => e.JuheCode)
                    .HasColumnType("int(11)")
                    .HasColumnName("juhe_code")
                    .HasComment("聚合返回的error_code");

                entity.Property(e => e.JuheOrderId)
                    .HasMaxLength(50)
                    .HasColumnName("juheOrderId")
                    .HasComment("聚合订单号");

                entity.Property(e => e.JuheReason)
                    .HasMaxLength(255)
                    .HasColumnName("juhe_reason")
                    .HasComment("聚合返回结果");

                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num")
                    .HasComment("本次发货数量");

                entity.Property(e => e.Ordercash)
                    .HasPrecision(11, 2)
                    .HasColumnName("ordercash")
                    .HasComment("最终扣费总额");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("productId")
                    .HasComment("商品id，当type2时，为第三方返回的cardid");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .HasColumnName("productName")
                    .HasComment("商品名称");

                entity.Property(e => e.ProductType)
                    .HasColumnType("int(11)")
                    .HasColumnName("productType")
                    .HasComment("商品类型，商品类型，1：礼品卡，2：话费直充，3：影视会员直充");

                entity.Property(e => e.Rechargenum)
                    .HasPrecision(11, 2)
                    .HasColumnName("rechargenum")
                    .HasComment("充值金额，type为2时代表充值话费金额（元）");

                entity.Property(e => e.SmsResult)
                    .HasMaxLength(255)
                    .HasColumnName("sms_result")
                    .HasDefaultValueSql("''")
                    .HasComment("短信发放结果");

                entity.Property(e => e.Source)
                    .HasColumnType("int(11)")
                    .HasColumnName("source")
                    .HasComment("来源，目前只有兑换：1");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasComment("状态：0失败，1成功（这里只是内部状态，只要第三方返回成功了就算成功，如果有回调则为订单状态 2 是成功 3 是失败 9 是未确认）");

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .HasColumnName("tel")
                    .HasComment("充值的手机号");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");

                entity.Property(e => e.UserOrderId)
                    .HasMaxLength(50)
                    .HasColumnName("userOrderId")
                    .HasComment("自己的订单号，（新第三方）订单规则：第一位为提卡还是直充C/T,第二位为配置表的product_type,剩下的为时间及随机数");
            });

            modelBuilder.Entity<LogLegueIntegral>(entity =>
            {
                entity.ToTable("log_legueIntegral");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid")
                    .HasComment("大厅Id");

                entity.Property(e => e.Integral)
                    .HasColumnType("int(11)")
                    .HasColumnName("integral")
                    .HasComment("积分值");

                entity.Property(e => e.LeagueId)
                    .HasColumnType("int(11)")
                    .HasColumnName("leagueId")
                    .HasComment("联盟ID");

                entity.Property(e => e.MemberId)
                    .HasColumnType("int(11)")
                    .HasColumnName("memberId")
                    .HasComment("成员ID");

                entity.Property(e => e.Operation)
                    .HasColumnType("int(11)")
                    .HasColumnName("operation")
                    .HasComment("操作类型");

                entity.Property(e => e.SumIntegral)
                    .HasColumnType("int(11)")
                    .HasColumnName("sum_integral")
                    .HasComment("操作后分数");

                entity.Property(e => e.TeamId)
                    .HasColumnType("int(11)")
                    .HasColumnName("teamId")
                    .HasComment("战队ID");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime")
                    .HasComment("生效时间");
            });

            modelBuilder.Entity<LogRedpackage>(entity =>
            {
                entity.ToTable("log_redpackage");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("id")
                    .HasComment("编号");

                entity.Property(e => e.Amount)
                    .HasPrecision(12, 2)
                    .HasColumnName("amount")
                    .HasComment("金额");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid")
                    .HasComment("区域id");

                entity.Property(e => e.CostTicket)
                    .HasColumnType("int(100)")
                    .HasColumnName("costTicket")
                    .HasComment("消耗的兑换券");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("订单创建时间");

                entity.Property(e => e.ErrCode)
                    .HasMaxLength(50)
                    .HasColumnName("errCode")
                    .HasComment("错误代码");

                entity.Property(e => e.ErrCodeDes)
                    .HasMaxLength(255)
                    .HasColumnName("errCodeDes")
                    .HasComment("错误代码描述");

                entity.Property(e => e.MchAppId)
                    .HasMaxLength(50)
                    .HasColumnName("mchAppId")
                    .HasComment("商户appid");

                entity.Property(e => e.MchId)
                    .HasMaxLength(50)
                    .HasColumnName("mchId")
                    .HasComment("微信商户号");

                entity.Property(e => e.OpenId)
                    .HasMaxLength(50)
                    .HasColumnName("openId")
                    .HasComment("微信openid");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .HasColumnName("orderId")
                    .HasComment("内部订单号/商户订单号");

                entity.Property(e => e.PaymentNo)
                    .HasMaxLength(50)
                    .HasColumnName("paymentNo")
                    .HasComment("微信订单号");

                entity.Property(e => e.PaymentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("paymentTime")
                    .HasComment("微信支付成功时间");

                entity.Property(e => e.Pf)
                    .HasMaxLength(20)
                    .HasColumnName("pf");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("productId")
                    .HasComment("商品id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("productName")
                    .HasComment("商品名称");

                entity.Property(e => e.ResultCode)
                    .HasMaxLength(50)
                    .HasColumnName("resultCode")
                    .HasComment("api业务执行结果");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasComment("状态");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid")
                    .HasComment("用户Id");
            });

            modelBuilder.Entity<LoginUserPfInfo>(entity =>
            {
                entity.ToTable("login_userPfInfo");

                entity.HasIndex(e => new { e.Areaid, e.Uid }, "areaid, uid");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.LastLogintime)
                    .HasColumnType("datetime")
                    .HasColumnName("lastLogintime")
                    .HasComment("最后登录时间");

                entity.Property(e => e.Pf)
                    .HasMaxLength(20)
                    .HasColumnName("pf");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid")
                    .HasComment("用户id");
            });

            modelBuilder.Entity<MailItemDrawLog>(entity =>
            {
                entity.ToTable("mail_ItemDrawLog");

                entity.HasIndex(e => e.Appid, "appid");

                entity.HasIndex(e => e.Createtime, "createtime");

                entity.HasIndex(e => e.Mailid, "mailid");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("createtime");

                entity.Property(e => e.Diamond)
                    .HasColumnType("int(11)")
                    .HasColumnName("diamond");

                entity.Property(e => e.Gold)
                    .HasColumnType("int(11)")
                    .HasColumnName("gold");

                entity.Property(e => e.Itemid)
                    .HasColumnType("int(11)")
                    .HasColumnName("itemid");

                entity.Property(e => e.Mailid)
                    .HasColumnType("int(11)")
                    .HasColumnName("mailid");

                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");

                entity.Property(e => e.Receive)
                    .HasColumnType("int(11)")
                    .HasColumnName("receive");

                entity.Property(e => e.Ticket)
                    .HasColumnType("int(11)")
                    .HasColumnName("ticket");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<MailServerLog>(entity =>
            {
                entity.ToTable("mail_ServerLog");

                entity.HasIndex(e => e.Endtime, "endtime");

                entity.HasIndex(e => e.State, "state");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid");

                entity.Property(e => e.Begintime)
                    .HasColumnType("datetime")
                    .HasColumnName("begintime")
                    .HasComment("开始时间");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .HasColumnName("content")
                    .HasDefaultValueSql("''")
                    .HasComment("邮件详情");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Endtime)
                    .HasColumnType("datetime")
                    .HasColumnName("endtime")
                    .HasComment("结束时间");

                entity.Property(e => e.Hasitems)
                    .HasColumnType("int(11)")
                    .HasColumnName("hasitems")
                    .HasComment("1:是2:否含有附件");

                entity.Property(e => e.Istop)
                    .HasColumnType("int(11)")
                    .HasColumnName("istop")
                    .HasComment("是1否0置顶");

                entity.Property(e => e.Items)
                    .HasMaxLength(1000)
                    .HasColumnName("items")
                    .HasComment("奖励内容");

                entity.Property(e => e.Operatorer)
                    .HasMaxLength(100)
                    .HasColumnName("operatorer")
                    .HasComment("创建人");

                entity.Property(e => e.Sendtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("sendtype")
                    .HasComment("类型：1全服玩家邮件，2指定玩家邮件");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'")
                    .HasComment("状态，-1：手动删除， 默认1：正常，2：过期");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasComment("邮件标题");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type")
                    .HasComment("邮件类型，1：文本，2：图片");

                entity.Property(e => e.Uids)
                    .HasColumnName("uids")
                    .HasComment("全服存0");
            });

            modelBuilder.Entity<MailServerUserLog>(entity =>
            {
                entity.ToTable("mail_ServerUserLog");

                entity.HasIndex(e => e.Mailid, "mailid");

                entity.HasIndex(e => new { e.Appid, e.Uid, e.Mailid }, "update");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid");

                entity.Property(e => e.Drawtime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("drawtime");

                entity.Property(e => e.Isdraw)
                    .HasColumnType("int(11)")
                    .HasColumnName("isdraw")
                    .HasComment("1：是，0：否领取");

                entity.Property(e => e.Isread)
                    .HasColumnType("int(11)")
                    .HasColumnName("isread")
                    .HasComment("阅读状态");

                entity.Property(e => e.Mailid)
                    .HasColumnType("int(11)")
                    .HasColumnName("mailid")
                    .HasComment("邮件编号");

                entity.Property(e => e.Readtime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("readtime");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasComment("邮件状态，1：正常，-1：删除");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<MailServerUserLogCopy>(entity =>
            {
                entity.ToTable("mail_ServerUserLog_copy");

                entity.HasIndex(e => e.Mailid, "mailid");

                entity.HasIndex(e => new { e.Appid, e.Uid, e.Mailid }, "update");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid");

                entity.Property(e => e.Drawtime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("drawtime");

                entity.Property(e => e.Isdraw)
                    .HasColumnType("int(11)")
                    .HasColumnName("isdraw")
                    .HasComment("1：是，0：否领取");

                entity.Property(e => e.Isread)
                    .HasColumnType("int(11)")
                    .HasColumnName("isread")
                    .HasComment("阅读状态");

                entity.Property(e => e.Mailid)
                    .HasColumnType("int(11)")
                    .HasColumnName("mailid")
                    .HasComment("邮件编号");

                entity.Property(e => e.Readtime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("readtime");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasComment("邮件状态，1：正常，-1：删除");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<SumConsumeArea>(entity =>
            {
                entity.ToTable("sum_consumeArea");

                entity.HasIndex(e => new { e.Provinceid, e.Cityid, e.Countyid, e.Gameid, e.Date }, "update");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areadiamond)
                    .HasColumnType("int(11)")
                    .HasColumnName("areadiamond")
                    .HasDefaultValueSql("'0'")
                    .HasComment("地区钻石");

                entity.Property(e => e.Cardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("cardcount");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Countyid)
                    .HasColumnType("int(11)")
                    .HasColumnName("countyid");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Diamond)
                    .HasColumnType("int(11)")
                    .HasColumnName("diamond");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Gecardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("gecardcount")
                    .HasComment("通用房卡数量");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumConsumeGameType>(entity =>
            {
                entity.ToTable("sum_consumeGameType");

                entity.HasIndex(e => new { e.Provinceid, e.Cityid, e.Countyid, e.Gameid, e.Roomtype, e.Gametype, e.Date }, "update");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areadiamond)
                    .HasColumnType("int(11)")
                    .HasColumnName("areadiamond")
                    .HasDefaultValueSql("'0'")
                    .HasComment("地区钻石");

                entity.Property(e => e.Cardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("cardcount");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Countyid)
                    .HasColumnType("int(11)")
                    .HasColumnName("countyid");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Diamond)
                    .HasColumnType("int(11)")
                    .HasColumnName("diamond");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Gametype)
                    .HasColumnType("int(11)")
                    .HasColumnName("gametype");

                entity.Property(e => e.Gecardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("gecardcount")
                    .HasComment("通用房卡数量");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Roomtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("roomtype");
            });

            modelBuilder.Entity<SumGameActiveUser>(entity =>
            {
                entity.ToTable("sum_gameActiveUser");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Clubcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubcount");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumGameActiveUserApp>(entity =>
            {
                entity.ToTable("sum_gameActiveUserAPP");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid");

                entity.Property(e => e.Clubcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubcount");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");
            });

            modelBuilder.Entity<SumGameActiveUserAppHour>(entity =>
            {
                entity.ToTable("sum_gameActiveUserAPP_Hour");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Appid)
                    .HasColumnType("int(11)")
                    .HasColumnName("appid");

                entity.Property(e => e.Clubcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubcount");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Hour)
                    .HasColumnType("int(11)")
                    .HasColumnName("hour");
            });

            modelBuilder.Entity<SumGameActiveUserHour>(entity =>
            {
                entity.ToTable("sum_gameActiveUser_Hour");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Clubcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubcount");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Hour)
                    .HasColumnType("int(11)")
                    .HasColumnName("hour");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumGameStart>(entity =>
            {
                entity.ToTable("sum_gameStart");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areadiamondcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("areadiamondcount")
                    .HasComment("地区钻石消耗量");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Clubareadiamondcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubareadiamondcount")
                    .HasComment("俱乐部地区钻石消耗量");

                entity.Property(e => e.Clubcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubcount")
                    .HasComment("俱乐部局数");

                entity.Property(e => e.Clubdiamondcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubdiamondcount")
                    .HasComment("俱乐部钻石消耗量");

                entity.Property(e => e.Clubgeneralroomcardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubgeneralroomcardcount")
                    .HasComment("俱乐部通用房卡消耗量");

                entity.Property(e => e.Clubnormalcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubnormalcount")
                    .HasComment("正常的俱乐部开房");

                entity.Property(e => e.Clubroomcardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubroomcardcount")
                    .HasComment("俱乐部房卡消耗量");

                entity.Property(e => e.Clubtakecount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubtakecount")
                    .HasComment("俱乐部代开房");

                entity.Property(e => e.Clubtotaldiamondcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubtotaldiamondcount");

                entity.Property(e => e.Clubtotalroomcardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("clubtotalroomcardcount");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Diamondcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("diamondcount")
                    .HasComment("钻石消耗数量");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Gametype)
                    .HasColumnType("int(11)")
                    .HasColumnName("gametype")
                    .HasComment("几局，（4局，8局）");

                entity.Property(e => e.Generalroomcardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("generalroomcardcount")
                    .HasComment("通用房卡消耗量");

                entity.Property(e => e.Normalcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("normalcount")
                    .HasComment("正常开局数");

                entity.Property(e => e.Placeplay)
                    .HasColumnType("int(11)")
                    .HasColumnName("placeplay")
                    .HasComment("地方打法");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Roomcardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("roomcardcount")
                    .HasComment("房卡消耗量");

                entity.Property(e => e.Roomtype)
                    .HasColumnType("int(11)")
                    .HasColumnName("roomtype")
                    .HasComment("房间类型，3人房，4人房");

                entity.Property(e => e.Takecount)
                    .HasColumnType("int(11)")
                    .HasColumnName("takecount")
                    .HasComment("代开房局数");

                entity.Property(e => e.Totalcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("totalcount")
                    .HasComment("总开局数");

                entity.Property(e => e.Totalcount1)
                    .HasColumnType("int(11)")
                    .HasColumnName("totalcount1")
                    .HasComment("总开局数");

                entity.Property(e => e.Totalcount2)
                    .HasColumnType("int(11)")
                    .HasColumnName("totalcount2")
                    .HasComment("总开局数");

                entity.Property(e => e.Totalcount3)
                    .HasColumnType("int(11)")
                    .HasColumnName("totalcount3")
                    .HasComment("总开局数");

                entity.Property(e => e.Totaldiamondcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("totaldiamondcount")
                    .HasComment("钻石消耗数量");

                entity.Property(e => e.Totalroomcardcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("totalroomcardcount");
            });

            modelBuilder.Entity<SumNewUserArea>(entity =>
            {
                entity.ToTable("sum_newUserArea");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumNewUserCity>(entity =>
            {
                entity.ToTable("sum_newUserCity");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumNewUserGame>(entity =>
            {
                entity.ToTable("sum_newUserGame");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumNewUserProvince>(entity =>
            {
                entity.ToTable("sum_newUserProvince");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumPlayerGameCount>(entity =>
            {
                entity.ToTable("sum_playerGameCount");

                entity.HasIndex(e => new { e.Provinceid, e.Cityid, e.Areaid, e.Gameid, e.Uid, e.Date }, "update_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Playcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("playcount");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<SumPlayerGameCountHour>(entity =>
            {
                entity.ToTable("sum_playerGameCount_Hour");

                entity.HasIndex(e => new { e.Provinceid, e.Cityid, e.Areaid, e.Gameid, e.Uid, e.Date, e.Hour }, "update_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Hour)
                    .HasColumnType("int(11)")
                    .HasColumnName("hour");

                entity.Property(e => e.Playcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("playcount");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Uid)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("uid");
            });

            modelBuilder.Entity<SumPlayerRetainedArea>(entity =>
            {
                entity.ToTable("sum_playerRetainedArea");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Count15)
                    .HasColumnType("int(11)")
                    .HasColumnName("count15");

                entity.Property(e => e.Count3)
                    .HasColumnType("int(11)")
                    .HasColumnName("count3");

                entity.Property(e => e.Count30)
                    .HasColumnType("int(11)")
                    .HasColumnName("count30");

                entity.Property(e => e.Count7)
                    .HasColumnType("int(11)")
                    .HasColumnName("count7");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumPlayerRetainedCity>(entity =>
            {
                entity.ToTable("sum_playerRetainedCity");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Count15)
                    .HasColumnType("int(11)")
                    .HasColumnName("count15");

                entity.Property(e => e.Count3)
                    .HasColumnType("int(11)")
                    .HasColumnName("count3");

                entity.Property(e => e.Count30)
                    .HasColumnType("int(11)")
                    .HasColumnName("count30");

                entity.Property(e => e.Count7)
                    .HasColumnType("int(11)")
                    .HasColumnName("count7");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumPlayerRetainedGame>(entity =>
            {
                entity.ToTable("sum_playerRetainedGame");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Count15)
                    .HasColumnType("int(11)")
                    .HasColumnName("count15");

                entity.Property(e => e.Count3)
                    .HasColumnType("int(11)")
                    .HasColumnName("count3");

                entity.Property(e => e.Count30)
                    .HasColumnType("int(11)")
                    .HasColumnName("count30");

                entity.Property(e => e.Count7)
                    .HasColumnType("int(11)")
                    .HasColumnName("count7");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumPlayerRetainedProvince>(entity =>
            {
                entity.ToTable("sum_playerRetainedProvince");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Count15)
                    .HasColumnType("int(11)")
                    .HasColumnName("count15");

                entity.Property(e => e.Count3)
                    .HasColumnType("int(11)")
                    .HasColumnName("count3");

                entity.Property(e => e.Count30)
                    .HasColumnType("int(11)")
                    .HasColumnName("count30");

                entity.Property(e => e.Count7)
                    .HasColumnType("int(11)")
                    .HasColumnName("count7");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");
            });

            modelBuilder.Entity<SumRuleUseCount>(entity =>
            {
                entity.ToTable("sum_ruleUseCount");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Provinceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("provinceid");

                entity.Property(e => e.Rulename)
                    .HasMaxLength(255)
                    .HasColumnName("rulename");

                entity.Property(e => e.Rulevalue)
                    .HasMaxLength(255)
                    .HasColumnName("rulevalue");
            });

            modelBuilder.Entity<SysArticle>(entity =>
            {
                entity.ToTable("sys_article");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Clicks)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("clicks");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Sortno)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sortno");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Typeid)
                    .HasColumnType("int(11)")
                    .HasColumnName("typeid");
            });

            modelBuilder.Entity<SysBack>(entity =>
            {
                entity.ToTable("sys_back");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasComment("后台名称");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .HasComment("描述");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasComment("状态：0、禁用，1、启用");
            });

            modelBuilder.Entity<SysBack20200513>(entity =>
            {
                entity.ToTable("sys_back_20200513");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasComment("后台名称");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .HasComment("描述");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasComment("状态：0、禁用，1、启用");
            });

            modelBuilder.Entity<SysBusinessUserRelation>(entity =>
            {
                entity.ToTable("sys_BusinessUserRelation");

                entity.HasIndex(e => e.Businessmobile, "business")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.Businessmobile)
                    .HasMaxLength(11)
                    .HasColumnName("businessmobile");

                entity.Property(e => e.Parentid)
                    .HasColumnType("int(32)")
                    .HasColumnName("parentid");

                entity.Property(e => e.Parentsysno)
                    .HasMaxLength(32)
                    .HasColumnName("parentsysno");
            });

            modelBuilder.Entity<SysCity>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Proviceid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sys_city");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Proviceid)
                    .HasColumnType("int(11)")
                    .HasColumnName("proviceid");

                entity.Property(e => e.Isvisible)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("isvisible");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SysCounty>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Cityid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sys_county");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Cityid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cityid");

                entity.Property(e => e.Isvisible)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("isvisible");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SysDict>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PRIMARY");

                entity.ToTable("sys_dict");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SysNo)
                    .HasMaxLength(32)
                    .HasColumnName("sysNo");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.DictValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("dictValue");

                entity.Property(e => e.Dictname)
                    .HasMaxLength(255)
                    .HasColumnName("dictname");

                entity.Property(e => e.ECode)
                    .HasMaxLength(255)
                    .HasColumnName("eCode");

                entity.Property(e => e.ParentNames)
                    .HasMaxLength(4000)
                    .HasColumnName("parentNames");

                entity.Property(e => e.ParentSysNo)
                    .HasMaxLength(32)
                    .HasColumnName("parentSysNo");

                entity.Property(e => e.ParentSysNos)
                    .HasMaxLength(4000)
                    .HasColumnName("parentSysNos");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state");

                entity.Property(e => e.TypeSysNo)
                    .HasMaxLength(32)
                    .HasColumnName("typeSysNo");
            });

            modelBuilder.Entity<SysDictType>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PRIMARY");

                entity.ToTable("sys_dictType");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SysNo)
                    .HasMaxLength(32)
                    .HasColumnName("sysNo");

                entity.Property(e => e.BackType)
                    .HasColumnType("int(11)")
                    .HasColumnName("backType")
                    .HasComment("来源于哪里，1：数据后台，2：代理商后台");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.ECode)
                    .HasMaxLength(255)
                    .HasColumnName("eCode");

                entity.Property(e => e.ETypeName)
                    .HasMaxLength(255)
                    .HasColumnName("eTypeName");

                entity.Property(e => e.ParentNames)
                    .HasMaxLength(4000)
                    .HasColumnName("parentNames");

                entity.Property(e => e.ParentSysNo)
                    .HasMaxLength(32)
                    .HasColumnName("parentSysNo");

                entity.Property(e => e.ParentSysNos)
                    .HasMaxLength(4000)
                    .HasColumnName("parentSysNos");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(255)
                    .HasColumnName("typeName");
            });

            modelBuilder.Entity<SysEmailLog>(entity =>
            {
                entity.ToTable("sys_emailLog");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AddUser)
                    .HasMaxLength(20)
                    .HasComment("发布人");

                entity.Property(e => e.AppId).HasColumnType("int(11)");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(255)
                    .HasComment("附件");

                entity.Property(e => e.Content)
                    .HasMaxLength(500)
                    .HasComment("更新内容");

                entity.Property(e => e.EditDb)
                    .HasMaxLength(255)
                    .HasComment("修改数据库");

                entity.Property(e => e.EditFile)
                    .HasMaxLength(255)
                    .HasComment("修改文件");

                entity.Property(e => e.EmailContent)
                    .HasColumnType("text")
                    .HasComment("邮件内容");

                entity.Property(e => e.EmailReceiveUser)
                    .HasMaxLength(100)
                    .HasComment("收件人");

                entity.Property(e => e.EmailSendPwd)
                    .HasMaxLength(100)
                    .HasComment("发件人密码");

                entity.Property(e => e.EmailSendUser)
                    .HasMaxLength(100)
                    .HasComment("发件人");

                entity.Property(e => e.EmailState)
                    .HasColumnType("int(11)")
                    .HasComment("0、未发送，1、发送成功，2、发送失败");

                entity.Property(e => e.EmailTitle)
                    .HasMaxLength(100)
                    .HasComment("邮件标题");

                entity.Property(e => e.GameEditDate)
                    .HasColumnType("datetime")
                    .HasComment("更新时间");

                entity.Property(e => e.GameId).HasColumnType("int(11)");

                entity.Property(e => e.Key).HasMaxLength(30);

                entity.Property(e => e.OperateResult)
                    .HasMaxLength(500)
                    .HasComment("操作结果");

                entity.Property(e => e.OperateUser)
                    .HasMaxLength(20)
                    .HasComment("操作人员");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasComment("0、未更新，1、已更新，2、取消");

                entity.Property(e => e.SysDate)
                    .HasColumnType("datetime")
                    .HasComment("系统时间");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.Version)
                    .HasMaxLength(255)
                    .HasComment("游戏版本");
            });

            modelBuilder.Entity<SysLoginLog>(entity =>
            {
                entity.ToTable("sys_loginLog");

                entity.HasIndex(e => e.Source, "source");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''")
                    .HasComment("登录的内容");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .HasColumnName("IP")
                    .HasDefaultValueSql("''")
                    .HasComment("IP地址");

                entity.Property(e => e.Logintime)
                    .HasColumnType("datetime")
                    .HasColumnName("logintime")
                    .HasComment("最后登录时间");

                entity.Property(e => e.Source)
                    .HasColumnType("int(1)")
                    .HasColumnName("source")
                    .HasDefaultValueSql("'0'")
                    .HasComment("登陆来源，0：账号登陆，1：手机登录，2：微信登录");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11)")
                    .HasColumnName("userid")
                    .HasComment("用户Id");
            });

            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.ToTable("sys_menu");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FunctionChLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FunctionEnLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("Table是表格里的按钮 Bar是框架外的按钮");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasComment("图标");

                entity.Property(e => e.IsMenu)
                    .HasColumnType("int(11)")
                    .HasColumnName("isMenu")
                    .HasComment("是否为菜单");

                entity.Property(e => e.IsMerge)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否为整合页面：0、否，1、是");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(255)
                    .HasColumnName("menuName")
                    .HasDefaultValueSql("''")
                    .HasComment("菜单名");

                entity.Property(e => e.MenuType)
                    .HasMaxLength(255)
                    .HasColumnName("menuType")
                    .HasDefaultValueSql("'1'")
                    .HasComment("菜单类型：1、数据后台，2、代理商后台");

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL")
                    .HasDefaultValueSql("''")
                    .HasComment("页面地址");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.ParentPageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("parentPageid")
                    .HasDefaultValueSql("'0'")
                    .HasComment("菜单id");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("备注");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort")
                    .HasDefaultValueSql("'0'")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("状态");
            });

            modelBuilder.Entity<SysMenu20190929>(entity =>
            {
                entity.ToTable("sys_menu_20190929");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FunctionChLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FunctionEnLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("Table是表格里的按钮 Bar是框架外的按钮");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasComment("图标");

                entity.Property(e => e.IsMenu)
                    .HasColumnType("int(11)")
                    .HasColumnName("isMenu")
                    .HasComment("是否为菜单");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(255)
                    .HasColumnName("menuName")
                    .HasDefaultValueSql("''")
                    .HasComment("菜单名");

                entity.Property(e => e.MenuType)
                    .HasMaxLength(255)
                    .HasColumnName("menuType")
                    .HasDefaultValueSql("''")
                    .HasComment("菜单类型");

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL")
                    .HasDefaultValueSql("''")
                    .HasComment("页面地址");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.ParentPageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("parentPageid")
                    .HasDefaultValueSql("'0'")
                    .HasComment("菜单id");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("备注");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort")
                    .HasDefaultValueSql("'0'")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("状态");
            });

            modelBuilder.Entity<SysMenu20191113>(entity =>
            {
                entity.ToTable("sys_menu_20191113");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FunctionChLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FunctionEnLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("Table是表格里的按钮 Bar是框架外的按钮");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasComment("图标");

                entity.Property(e => e.IsMenu)
                    .HasColumnType("int(11)")
                    .HasColumnName("isMenu")
                    .HasComment("是否为菜单");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(255)
                    .HasColumnName("menuName")
                    .HasDefaultValueSql("''")
                    .HasComment("菜单名");

                entity.Property(e => e.MenuType)
                    .HasMaxLength(255)
                    .HasColumnName("menuType")
                    .HasDefaultValueSql("'1'")
                    .HasComment("菜单类型：1、数据后台，2、代理商后台");

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL")
                    .HasDefaultValueSql("''")
                    .HasComment("页面地址");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.ParentPageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("parentPageid")
                    .HasDefaultValueSql("'0'")
                    .HasComment("菜单id");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("备注");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort")
                    .HasDefaultValueSql("'0'")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("状态");
            });

            modelBuilder.Entity<SysMenu20200513>(entity =>
            {
                entity.ToTable("sys_menu_20200513");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FunctionChLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FunctionEnLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("Table是表格里的按钮 Bar是框架外的按钮");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasComment("图标");

                entity.Property(e => e.IsMenu)
                    .HasColumnType("int(11)")
                    .HasColumnName("isMenu")
                    .HasComment("是否为菜单");

                entity.Property(e => e.IsMerge)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否为整合页面：0、否，1、是");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(255)
                    .HasColumnName("menuName")
                    .HasDefaultValueSql("''")
                    .HasComment("菜单名");

                entity.Property(e => e.MenuType)
                    .HasMaxLength(255)
                    .HasColumnName("menuType")
                    .HasDefaultValueSql("'1'")
                    .HasComment("菜单类型：1、数据后台，2、代理商后台");

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL")
                    .HasDefaultValueSql("''")
                    .HasComment("页面地址");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.ParentPageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("parentPageid")
                    .HasDefaultValueSql("'0'")
                    .HasComment("菜单id");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("备注");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort")
                    .HasDefaultValueSql("'0'")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("状态");
            });

            modelBuilder.Entity<SysMenu20211210>(entity =>
            {
                entity.ToTable("sys_menu20211210");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FunctionChLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FunctionEnLst)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("Table是表格里的按钮 Bar是框架外的按钮");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasComment("图标");

                entity.Property(e => e.IsMenu)
                    .HasColumnType("int(11)")
                    .HasColumnName("isMenu")
                    .HasComment("是否为菜单");

                entity.Property(e => e.IsMerge)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否为整合页面：0、否，1、是");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(255)
                    .HasColumnName("menuName")
                    .HasDefaultValueSql("''")
                    .HasComment("菜单名");

                entity.Property(e => e.MenuType)
                    .HasMaxLength(255)
                    .HasColumnName("menuType")
                    .HasDefaultValueSql("'1'")
                    .HasComment("菜单类型：1、数据后台，2、代理商后台");

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL")
                    .HasDefaultValueSql("''")
                    .HasComment("页面地址");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.ParentPageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("parentPageid")
                    .HasDefaultValueSql("'0'")
                    .HasComment("菜单id");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''")
                    .HasComment("备注");

                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort")
                    .HasDefaultValueSql("'0'")
                    .HasComment("排序");

                entity.Property(e => e.State)
                    .HasColumnType("int(255)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("状态");
            });

            modelBuilder.Entity<SysMerge>(entity =>
            {
                entity.ToTable("sys_merge");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasComment("创建时间");

                entity.Property(e => e.MergedPageIds)
                    .HasMaxLength(500)
                    .HasComment("整合的页面");

                entity.Property(e => e.PageId)
                    .HasColumnType("int(11)")
                    .HasComment("菜单编号");
            });

            modelBuilder.Entity<SysParameter>(entity =>
            {
                entity.HasKey(e => e.SysNo)
                    .HasName("PRIMARY");

                entity.ToTable("sys_parameter");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.SysNo)
                    .HasMaxLength(32)
                    .HasColumnName("sysNo");

                entity.Property(e => e.ParamKey)
                    .HasMaxLength(50)
                    .HasColumnName("paramKey");

                entity.Property(e => e.ParamValue)
                    .HasColumnType("text")
                    .HasColumnName("paramValue");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state");
            });

            modelBuilder.Entity<SysProvince>(entity =>
            {
                entity.ToTable("sys_province");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Areaid)
                    .HasColumnType("int(11)")
                    .HasColumnName("areaid");

                entity.Property(e => e.Isvisible)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("isvisible");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Pf)
                    .HasMaxLength(20)
                    .HasColumnName("pf");
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.ToTable("sys_role");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark")
                    .HasDefaultValueSql("''")
                    .HasComment("注释");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(255)
                    .HasColumnName("roleName")
                    .HasDefaultValueSql("''")
                    .HasComment("角色名称");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'")
                    .HasComment("0为禁用 1为启用");
            });

            modelBuilder.Entity<SysRoleBtn>(entity =>
            {
                entity.ToTable("sys_roleBtn");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.Roleid)
                    .HasColumnType("int(11)")
                    .HasColumnName("roleid");
            });

            modelBuilder.Entity<SysRoleGame>(entity =>
            {
                entity.ToTable("sys_roleGame");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Roleid)
                    .HasColumnType("int(11)")
                    .HasColumnName("roleid");
            });

            modelBuilder.Entity<SysRoleMenu>(entity =>
            {
                entity.ToTable("sys_roleMenu");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.Roleid)
                    .HasColumnType("int(11)")
                    .HasColumnName("roleid");
            });

            modelBuilder.Entity<SysRoleUser>(entity =>
            {
                entity.ToTable("sys_roleUser");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Roleid)
                    .HasColumnType("int(11)")
                    .HasColumnName("roleid");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11)")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<SysSlide>(entity =>
            {
                entity.ToTable("sys_slide");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Clicks)
                    .HasColumnType("int(11)")
                    .HasColumnName("clicks");

                entity.Property(e => e.Content)
                    .HasMaxLength(4000)
                    .HasColumnName("content");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Picture)
                    .HasMaxLength(255)
                    .HasColumnName("picture");

                entity.Property(e => e.Sortno)
                    .HasColumnType("int(11)")
                    .HasColumnName("sortno");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Typeid)
                    .HasColumnType("int(11)")
                    .HasColumnName("typeid");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<SysSmsConfig>(entity =>
            {
                entity.ToTable("sys_smsConfig");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Msg)
                    .HasMaxLength(255)
                    .HasColumnName("msg")
                    .HasComment("消息内容");

                entity.Property(e => e.Tempid)
                    .HasMaxLength(10)
                    .HasComment("模板Id");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type")
                    .HasComment("发送类型");
            });

            modelBuilder.Entity<SysSystemLog>(entity =>
            {
                entity.ToTable("sys_systemLog");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .HasColumnName("action");

                entity.Property(e => e.ActionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("actionType");

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .HasColumnName("description");

                entity.Property(e => e.DoTime)
                    .HasColumnType("datetime")
                    .HasColumnName("doTime");

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .HasColumnName("ip");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.ToTable("sys_user");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(32)")
                    .HasColumnName("id");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .HasColumnName("account")
                    .HasComment("登录账号")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime")
                    .HasComment("注册时间");

                entity.Property(e => e.Ecode)
                    .HasMaxLength(20)
                    .HasColumnName("ECode")
                    .HasDefaultValueSql("''")
                    .HasComment("英文编码");

                entity.Property(e => e.Lastlogintime)
                    .HasColumnType("datetime")
                    .HasColumnName("lastlogintime");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(12)
                    .HasColumnName("mobile")
                    .HasComment("英文编码")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.ParentSysNo)
                    .HasMaxLength(32)
                    .HasColumnName("parentSysNo");

                entity.Property(e => e.Parentid)
                    .HasColumnType("bigint(32)")
                    .HasColumnName("parentid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Password)
                    .HasMaxLength(32)
                    .HasColumnName("password")
                    .HasComment("密码")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Remark)
                    .HasMaxLength(4000)
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.Sex)
                    .HasColumnType("int(11)")
                    .HasColumnName("sex")
                    .HasComment("性别，1男，2女");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasComment("状态");

                entity.Property(e => e.SysNo)
                    .HasMaxLength(32)
                    .HasColumnName("sysNo");

                entity.Property(e => e.Truename)
                    .HasMaxLength(50)
                    .HasColumnName("truename")
                    .HasComment("员工姓名")
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<SysUserBtn>(entity =>
            {
                entity.ToTable("sys_userBtn");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11)")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<SysUserGame>(entity =>
            {
                entity.ToTable("sys_userGame");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Gameid)
                    .HasColumnType("int(11)")
                    .HasColumnName("gameid");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11)")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<SysUserMenu>(entity =>
            {
                entity.ToTable("sys_userMenu");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Pageid)
                    .HasColumnType("int(11)")
                    .HasColumnName("pageid");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11)")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<SysUserWechat>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Openid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sys_user_wechat");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Openid)
                    .HasMaxLength(32)
                    .HasColumnName("openid");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("createtime");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(12)
                    .HasColumnName("mobile");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .HasColumnName("nickname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("updatetime");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11)")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<UtilLivecode>(entity =>
            {
                entity.ToTable("util_livecode");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CodeUrl)
                    .HasMaxLength(500)
                    .HasColumnName("codeUrl")
                    .HasComment("对应的合码url地址");

                entity.Property(e => e.CreateTime).HasColumnName("createTime");

                entity.Property(e => e.CutNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("cutNum");

                entity.Property(e => e.SysNo)
                    .HasMaxLength(32)
                    .HasColumnName("sysNo");

                entity.Property(e => e.Tag)
                    .HasMaxLength(200)
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<UtilSendMsg>(entity =>
            {
                entity.ToTable("util_sendMsg");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count")
                    .HasComment("数量");

                entity.Property(e => e.Createtime)
                    .HasColumnType("datetime")
                    .HasColumnName("createtime");

                entity.Property(e => e.Msg)
                    .HasMaxLength(255)
                    .HasColumnName("msg")
                    .HasDefaultValueSql("''")
                    .HasComment("发送短信内容");

                entity.Property(e => e.Operatoruser)
                    .HasMaxLength(32)
                    .HasColumnName("operatoruser")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Path)
                    .HasMaxLength(255)
                    .HasColumnName("path")
                    .HasComment("存放路径");

                entity.Property(e => e.State)
                    .HasColumnType("int(1)")
                    .HasColumnName("state")
                    .HasComment("发送状态");

                entity.Property(e => e.Sysno)
                    .HasMaxLength(20)
                    .HasColumnName("sysno")
                    .HasDefaultValueSql("''")
                    .HasComment("唯一标识，为文本名字");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

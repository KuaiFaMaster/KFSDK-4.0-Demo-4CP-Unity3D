# 快发助手Unity3D接入文档
## 1.SDK结构

![](C:/Users/Administrator/Desktop/t.jpg)

文件名| 描述
---|---
KFSDK_UNITY_DEMO | 可以运行的demo
KF.unitypackage |依赖插件

## 2.接入步骤

![](C:/Users/Administrator/Desktop/b.jpg)

如图所示依次选择 Assets-->Import Package-->Custom Package -->KF.unitypackage

## 3.业务功能接口

### 3.1 初始化接口(必接)

`KFSDKInterfaceAndroid.Instance.initSDK ();`

### 3.2 登陆接口(必接)

`KFSDKInterfaceAndroid.Instance.login ();`

### 3.3 支付接口(必接)

`KFSDKInterfaceAndroid.Instance.pay (payparam);`

需要传入一个Json字符串：

amount // ==所购买商品金额==

product_name  // ==所购买商品的名称==

product_num // ==所购买商品的数量==

server_id // ==服务器id== 

product_id // ==所购买商品id==

game_extend // ==额外参数没有传== " "

notify_url // ==应用方提供的支付结果通知uri,没有先传任意测试字符串==

conin_name  // ==商品名称==

rate // ==兑换比例==

role_id // ==角色id==

role_name // ==角色名称==

role_level // ==角色等级==

server_name // ==服务器名称==


`{'amount':'1','product_name':'milk','product_num':'1','server_id':'12','product_id':'1','game_extend':'game_extend','notify_url':'notify_url','conin_name':'conin_name','rate':'10','role_id':'12','role_name':'role_name','role_level':'123','server_name':'server_name'}`

### 3.4 获取订单接口

`KFSDKInterfaceAndroid.Instance.getOrderInfo ();`

### 3.5 注销接口(必接)

`KFSDKInterfaceAndroid.Instance.logout ();`

### 3.6 退出游戏(必接)

`KFSDKInterfaceAndroid.Instance.exit ();`

### 3.7 切换用户

`KFSDKInterfaceAndroid.Instance.changeAccout ();`

## 4.数据统计接口

### 4.1 登陆统计

`KFSDKInterfaceAndroid.Instance.statisticRecordLogin (loginJson);` // ==登陆统计==

`KFSDKInterfaceAndroid.Instance.statisticEnterGame (enterJson);` // ==进入游戏==

需要传入一个Json字符串：

user_type // ==用户类型：0为临时账户，1为注册用户，2为第三方用户==

server_id // ==服务器id==

role_id // ==角色id==

role_user_id // ==账户id==

role_name // ==角色名称==

role_level // ===角色等级==

server_name // ===服务器名称==

use_nick //==账户account==

party_name //==角色所在帮派或工会名称==

vip_level // ==VIP等级==


`{'user_type':'1','server_id':'1','role_id':'1','role_user_id':'2','role_name':'role_name','role_level':'2','server_name':'1','use_nick':'use_nick','party_name':'party_name','vip_level':'2'}`

### 4.2 创建角色

`KFSDKInterfaceAndroid.Instance.statisticCreateRole (createRoleJson);`

需要传入一个Json字符串：

server_id // ==服务器id==

role_id // ==角色id==

role_user_id // ==账户id==

role_level // ===角色等级==

role_name // ==角色名称==

server_name // ===服务器名称==

`{'server_id':'1','role_id':'1','role_user_id':'2','role_level':'2','role_name':'role_name','server_name':'1'}`

### 4.3 角色升级

`KFSDKInterfaceAndroid.Instance.statisticRoleUp (roleUpJson);`

需要传入一个Json字符串：

role_id // ==角色id==

role_level // ===角色等级==

role_name // ==角色名称==

server_id // ==服务器id==

server_name // ===服务器名称==

role_user_id // ==账户id==

`{'role_id':'1','role_level':'2','role_name':'role_name','server_id':'1','server_name':'1','role_user_id':'2'}`



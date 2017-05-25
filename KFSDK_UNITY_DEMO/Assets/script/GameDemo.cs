using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameDemo : MonoBehaviour {


	//private KFUnitySDKCallBack unityCallback;

	// Use this for initialization
	void Start () {

		doInit ();

	}


	void OnGUI()  
	{  
		//登陆按钮  
		if(GUI.Button(new Rect(100,0,Screen.width-200,Screen.height/10),"Login"))  
		{  
			doLogin();
		}  

		//注销按钮  
		if(GUI.Button(new Rect(100,Screen.height/10+10,Screen.width-200,Screen.height/10),"Logout"))  
		{  
			doLogout();
		}  
		//退出游戏
		if (GUI.Button (new Rect (100, Screen.height/5+20, Screen.width-200, Screen.height/10), "Exit Game")) {
			doExit();
		}

		//切换用户
		if(GUI.Button(new Rect(100,(Screen.height/10)*3+30,Screen.width-200,Screen.height/10),"Change Account")){
			doChangeAccout();
		}

		//支付
		if(GUI.Button(new Rect(100,(Screen.height/10)*4+40,Screen.width-200,Screen.height/10),"Pay")){
			string payparam = "{'amount':'1','product_name':'milk','product_num':'1','server_id':'12','product_id':'1','game_extend':'game_extend','notify_url':'notify_url','conin_name':'conin_name','rate':'10','role_id':'12','role_name':'role_name','role_level':'123','server_name':'server_name'}";
			doPay(payparam);
		}

		//获取订单
		if (GUI.Button (new Rect (100, (Screen.height/10)*5+50, Screen.width-200, Screen.height/10), "Get OrderInfo")) {
			getOrderInfo();
		}
		//统计登陆
		if (GUI.Button (new Rect (100, (Screen.height/10)*6+60, Screen.width-200, Screen.height/10), "Enter Game")) {
		//	string loginJson = "{'role_id':'2','server_id':'1','server_name':'server_name','role_name':'role_name','role_level':'role_level'}";	
			string loginJson ="{'user_type':'1','server_id':'1','role_id':'1','role_user_id':'2','role_name':'role_name','role_level':'2','server_name':'1','use_nick':'use_nick','party_name':'party_name','role_name':'2'}";
			statisticEnterGame(loginJson);
			statisticRecordLogin(loginJson);
		
		}
		//创建角色
		if (GUI.Button (new Rect (100, (Screen.height/10)*7+70, Screen.width-200, Screen.height/10),"Create Role")) {
			string createRoleJson = "{'server_id':'1','role_id':'1','role_user_id':'2','role_level':'2','role_name':'role_name','server_name':'1'}";
			statisticCreateRole(createRoleJson);
		}
		//角色升级
		if(GUI.Button(new Rect(100,(Screen.height/10)*8+80,Screen.width-200,Screen.height/10),"Role up")){
			string roleUpJson = "{'role_id':'1','role_level':'2','role_name':'role_name','server_id':'1','server_name':'1','role_user_id':'2'}";
			statisticRoleUp(roleUpJson);
		}


	}  




	void doInit(){
		Debug.Log ("unity init");
		KFSDKInterfaceAndroid.Instance.initSDK ();
	}

	void doLogin(){
		Debug.Log ("unity login");
		KFSDKInterfaceAndroid.Instance.login ();
	}

	void doLogout(){
		Debug.Log ("unity logout");
		KFSDKInterfaceAndroid.Instance.logout ();
	}

	void doExit(){
		Debug.Log ("unity exit");
		KFSDKInterfaceAndroid.Instance.exit ();
	}

	void doChangeAccout(){
		Debug.Log ("unity changeAccout");
		KFSDKInterfaceAndroid.Instance.changeAccout ();
	}

	void doPay(string payparam){
		Debug.Log ("unity pay");
		KFSDKInterfaceAndroid.Instance.pay (payparam);
	}

	void getOrderInfo(){
		Debug.Log ("getOrderInfo");
		KFSDKInterfaceAndroid.Instance.getOrderInfo ();
	}

	void statisticRecordLogin(string loginJson){
		Debug.Log ("statisticRecordLogin");
		KFSDKInterfaceAndroid.Instance.statisticRecordLogin (loginJson);
	}

	void statisticEnterGame(string enterJson){
		Debug.Log ("statisticEnterGame");
		KFSDKInterfaceAndroid.Instance.statisticEnterGame (enterJson);
	}
	void statisticRoleUp(string roleUpJson){
		Debug.Log ("statisticRoleUp");
		KFSDKInterfaceAndroid.Instance.statisticRoleUp (roleUpJson);
	}
	void statisticCreateRole(string createRoleJson){
		Debug.Log ("statisticCreateRole");
		KFSDKInterfaceAndroid.Instance.statisticCreateRole (createRoleJson);
	}

}

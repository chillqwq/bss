<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
		<title>登录界面</title>
		<link rel="stylesheet" href="css/reset.css" />
		<link rel="stylesheet" href="css/common.css" />
		<link rel="stylesheet" href="css/font-awesome.min.css" />
	</head>
	<body>
		<div class="wrap login_wrap">
			<div class="content">
				<div class="logo"></div>
				<div class="login_box">	
					
					<div class="login_form">
						<div class="login_title">
							登录
						</div>
						<form action="#" method="post" runat="server" >
							
							<div class="form_text_ipt">
								<input name="username" type="text" placeholder="会员编号">
							</div>
							<div class="ececk_warning"><span>会员编号不能为空</span></div>
							<div class="form_text_ipt">
								<input name="password" type="password" placeholder="密码">
							</div>
							<div class="ececk_warning"><span>密码不能为空</span></div>

							<div class="form_btn">
								<button type="button" runat="server" onserverclick="Button1_Click">登录</button>
							</div>
							<div class="form_reg_btn">
								<span>还没有帐号？</span><a href="register.aspx">马上注册</a>
							</div>
						</form>
						<div class="other_login">
						</div>
					</div>
				</div>
			</div>
		</div>
	</body>
</html>

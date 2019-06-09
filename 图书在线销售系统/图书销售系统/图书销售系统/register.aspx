<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
		<meta charset="utf-8">
		<title>注册界面</title>
		<link rel="stylesheet" href="css/reset.css" />
		<link rel="stylesheet" href="css/common.css" />
		<link rel="stylesheet" href="css/font-awesome.min.css" />
	</head>
	<body>
		<div class="wrap login_wrap">
			<div>
				
				<div class="logo"></div>
				
				<div class="login_box">	
					
					<div class="login_form">
						<div class="login_title">
							注册
						</div>
						<form  runat="server" method="post">		
							<div class="form_text_ipt">
								<input name="username" type="text" placeholder="会员编号">
							</div>
							<div class="ececk_warning"><span>会员编号不能为空</span></div>
							<div class="form_text_ipt">
								<input name="password" type="password" placeholder="密码">
							</div>
							<div class="ececk_warning"><span>密码不能为空</span></div>
							<div class="form_text_ipt">
								<input name="repassword" type="password" placeholder="重复密码">
							</div>
							<div class="ececk_warning"><span>密码不能为空</span></div>
							<div class="form_text_ipt">
								<input name="user_name" type="text" placeholder="姓名">
							</div>
							<div class="ececk_warning"><span>姓名不能为空</span></div>
							<div class="form_text_ipt">
								<input name="useridcard" type="text" placeholder="身份证">
							</div>
							<div class="ececk_warning"><span>身份证不能为空</span></div>
							<div class="form_btn">
								<button type="button"  runat="server" onserverclick="Button2_Click">注册</button>
							</div>
							<div class="form_reg_btn">
								<span>已有帐号？</span><a href="login.aspx">马上登录</a>
							</div>
						</form>

					</div>
				</div>
			</div>
		</div>
		<script type="text/javascript" src="js/jquery.min.js" ></script>
		<script type="text/javascript" src="js/common.js" ></script>
		<div style="text-align:center;">
</div>
	</body>
</html>


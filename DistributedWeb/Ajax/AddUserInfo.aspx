<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUserInfo.aspx.cs" Inherits="DistributedWeb.AddUserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>��������</title>
<link rel="stylesheet" rev="stylesheet" href="/css/style.css" type="text/css" media="all" /> 
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/adduser.js" type="text/javascript"></script>
</head>

<body class="ContentBody">
<form id="Form1"  >
<div class="MainDiv">
<table width="99%" border="0" cellpadding="0" cellspacing="0" class="CContent">
  <tr>
      <th class="tablestyle_title" >�����û�</th>
  </tr>
  <tr>
    <td class="CPanel">
		
		<table border="0" cellpadding="0" cellspacing="0" style="width:100%">
		<tr>
			<td align="left">
				��			
				<input type="button" name="Submit2" value="����" class="button" onclick="window.history.go(-1);"/>			</td>
		</tr>
		<tr align="center">
			<td class="TablePanel">�����û�</td>
		</tr>
			<TR>
			<TD width="100%">
				<fieldset style="height:100%;">
				<legend>������Ϣ</legend>
					  <table border="0" cellpadding="2" cellspacing="1" style="width:100%">
					 
                     <tr>
					    <td nowrap align="right" width="15%">��½�û���:</td>
					    <td width="35%"><input name='txt3' type="text" class="text" style="width:154px" value="" id="txtLoginUserName" />
				         
                          </td>
					    <td width="16%" align="right" nowrap="nowrap">�û�״̬:</td>
					    <td width="34%">
                          <select id="ddlUserStatus">
                          <option value="0">����</option>
                          <option value="1">����</option>
                          <option value="2">ɾ��</option>
                          <option value="3">����</option>
                          </select>
                          </td>
					  </tr>
                      <tr>
					    <td nowrap align="right" width="15%">��½����:</td>
					    <td width="35%"><input name='txt3' type="text" class="text" style="width:154px" value="" id="txtPwd" />
				         
                          </td>
					    <td width="16%" align="right" nowrap="nowrap">��½����:</td>
					    <td width="34%">
                          <select id="ddlLoginType">
                          <option value="0">�����û�</option>
                          <option value="1">Web�˵�¼�û�</option>
                          <option value="2">�ͻ��˵�¼�û�</option>
                          <option value="3">������û�</option>
                           <option value="4">�ƶ����û�</option>
                          </select>
                          </td>
					  </tr>


					  <tr>
					    <td nowrap align="right" width="15%">�û�����:</td>
					    <td width="35%"><input name='txt3' type="text" class="text" style="width:154px" value="" id="txtUserName" />
				         
                          </td>
					    <td width="16%" align="right" nowrap="nowrap">�û��Ա�:</td>
					    <td width="34%">
                          <select id="ddlGender">
                          <%=GetOptions(GenderList)%>
                          </select>
                          </td>
					  </tr>
					    
					    
					  <tr>
					    <td nowrap="nowrap" align="right">�ֻ���:</td>
					    <td><input class="text" name='datevalue21' style="width:154px" value="" id="txtPhone"/>
                            
                          </td>
					    <td align="right">��Ф:</td>
					    <td>
                          <select id="ddlZodiac">
                          <%=GetOptions(ZodiacList)%>
                          </select>
                          </td>
					  </tr>
					  <tr>
					    <td align="right">����ʡ:</td>
						<td>
                            <select id="ddlProv">
                          <%=GetOptions(ProvList)%>
                          </select>
						</td>
					    <td align="right">������:</td>
					    <td>
                             <select id="ddlCity">
                          <%=GetOptions(CityList)%>
                          </select>
						</td>
					  </tr>
					  <tr>
                        <td align="right">����:</td>
					    <td>
                          <select id="ddlConstellation">
                          <%=GetOptions(ConstellationList)%>
                          </select>
						</td>
					    <td align="right">ѧ��:</td>
					    <td>
                          <select id="ddlDegree">
                          <%=GetOptions(DegreeList)%>
                          </select>
						</td>
					    </tr>
					  <tr>
                        <td align="right">����:</td>
					    <td>  
                          <select id="ddlNation">
                          <%=GetOptions(NationList)%>
                          </select>
                          </td>
					    <td align="right"></td>
					    <td>
                       
                          </td>
					    </tr>
					 
					  </table>
			  <br />
				</fieldset>			</TD>
		</TR>
		</TABLE>
	
	
	 </td>
  </tr>
  
  
		
		
		
		<TR>
			<TD colspan="2" align="center" height="50px">
			 
               <input type="button" name="Submit2" value="����" class="button" id="btnsave" />
			<input type="button" name="Submit2" value="����" class="button" onclick="window.history.go(-1);"/></TD>
		</TR>
		</TABLE>
	
	
	 </td>
  </tr>
  
  
  
  </table>

</div>

  </form>
</body>
</html>

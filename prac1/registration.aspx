<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="prac1.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 212px;
        }
        .auto-style2 {
            width: 211px;
        }
        .auto-style5 {
            width: 211px;
            height: 114px;
        }
        .auto-style6 {
            height: 114px;
        }
        .auto-style7 {
            height: 114px;
            width: 288px;
        }
        .auto-style9 {
            width: 307px;
        }
        .auto-style11 {
            margin-left: 103px;
        }
        .auto-style15 {
            width: 335px;
        }
        .auto-style16 {
            width: 100%;
        }
        .auto-style18 {
            width: 101px;
        }
        .auto-style19 {
            width: 270px;
        }
        .auto-style20 {
            width: 288px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ENTER THE RECORDS</div>
        <table class="auto-style16">
            <tr>
                <td class="auto-style1">Name</td>
                <td class="auto-style18">
                    <asp:TextBox ID="TextBox1" runat="server" Width="263px"></asp:TextBox>
                </td>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="user name needed" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Age</td>
                <td class="auto-style18">
                    <asp:TextBox ID="TextBox2" runat="server" Width="259px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="age is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td class="auto-style18">
                    <asp:TextBox ID="TextBox3" runat="server" Width="269px"></asp:TextBox>
                </td>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ForeColor="Red">email is required</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="RegularExpressionValidator" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">valid email-address</asp:RegularExpressionValidator>
                    </td>
            </tr>
        </table>
        <table class="auto-style16">
            <tr>
                <td class="auto-style1">password</td>
                <td class="auto-style19">
                    <asp:TextBox ID="TextBox4" runat="server" MaxLength="8" TextMode="Password" Width="274px"></asp:TextBox>
                </td>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp; 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" EnableTheming="False" ErrorMessage="password required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="CustomValidator" ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Re-type password</td>
                <td class="auto-style19">
                    <asp:TextBox ID="TextBox5" runat="server" Width="278px" MaxLength="8" TextMode="Password"></asp:TextBox>
                </td>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="RequiredFieldValidator" ForeColor="Red">required field</asp:RequiredFieldValidator>
&nbsp;&nbsp;
                    <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="CustomValidator" ForeColor="Red"></asp:CustomValidator>
                    <br />
                    <br />
&nbsp;
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="CompareValidator" ForeColor="Red">incorrect email</asp:CompareValidator>
                    </td>
            </tr>
            <tr>
                <td class="auto-style1">gender</td>
                <td class="auto-style19">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Female" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Male" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style16">
            <tr>
                <td class="auto-style5">hobby</td>
                <td class="auto-style7">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>singing</asp:ListItem>
                        <asp:ListItem>painting</asp:ListItem>
                        <asp:ListItem>dancing</asp:ListItem>
                        <asp:ListItem>reading books</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    image</td>
                <td class="auto-style20">
&nbsp;&nbsp;&nbsp;
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style20">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="save records" Width="162px" CssClass="auto-style11" />
                    <br />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="error_message"></asp:Label>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
